using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Tarea_Credito_SE   
{
    public partial class Form1 : Form
    {
        // Base de conocimientos y registro de lo que hizo el motor
        private List<Regla> reglas;
        private List<string> traza = new List<string>();

        public Form1()
        {
            InitializeComponent();
            InicializarReglas();
        }

        private void InicializarReglas()
        {
            reglas = new List<Regla>
            {
                // ---------- 1. CAPACIDAD DE PAGO ----------
                new Regla("C1: Ingreso > L 50,000 y empleo permanente -> Capacidad ALTA",
                    h => h.Contains("ingreso_alto") && h.Contains("empleo_permanente"),
                    "Capacidad:Alta"),

                new Regla("C2: Ingreso entre L 25,000 y L 50,000 y empleo permanente -> Capacidad MEDIA",
                    h => h.Contains("ingreso_medio") && h.Contains("empleo_permanente"),
                    "Capacidad:Media"),

                new Regla("C3: Ingreso < L 25,000 o empleo temporal -> Capacidad BAJA",
                    h => h.Contains("ingreso_bajo") || !h.Contains("empleo_permanente"),
                    "Capacidad:Baja"),

                // ---------- 2. HISTORIAL CREDITICIO ----------
                new Regla("H1: Sin atrasos en préstamos anteriores -> Buen historial",
                    h => !h.Contains("atrasos"),
                    "Historial:Bueno"),

                new Regla("H2: Atrasos frecuentes -> Historial riesgoso",
                    h => h.Contains("atrasos"),
                    "Historial:Riesgoso"),

                // ---------- 3. TIPO DE CLIENTE ----------
                new Regla("K1: Capacidad alta y buen historial -> Cliente PREFERENCIAL",
                    h => h.Contains("Capacidad:Alta") && h.Contains("Historial:Bueno"),
                    "Cliente:Preferencial"),

                new Regla("K2: Capacidad media y buen historial -> Cliente REGULAR",
                    h => h.Contains("Capacidad:Media") && h.Contains("Historial:Bueno"),
                    "Cliente:Regular"),

                new Regla("K3: Capacidad baja o historial riesgoso -> Cliente de RIESGO",
                    h => h.Contains("Capacidad:Baja") || h.Contains("Historial:Riesgoso"),
                    "Cliente:Riesgo"),

                // ---------- 4. CRÉDITO QUE PUEDE SOLICITAR ----------
                new Regla("P1: Cliente preferencial -> Crédito hipotecario",
                    h => h.Contains("Cliente:Preferencial"),
                    "Credito:Hipotecario"),

                new Regla("P2: Cliente regular -> Crédito vehicular",
                    h => h.Contains("Cliente:Regular"),
                    "Credito:Vehicular"),

                new Regla("P3: Cliente de riesgo -> Préstamo personal",
                    h => h.Contains("Cliente:Riesgo"),
                    "Credito:Personal"),

                // ---------- 5. PLAZO RECOMENDADO ----------
                new Regla("Z1: Crédito hipotecario -> Plazo LARGO",
                    h => h.Contains("Credito:Hipotecario"),
                    "Plazo:Largo"),

                new Regla("Z2: Crédito vehicular -> Plazo MEDIO",
                    h => h.Contains("Credito:Vehicular"),
                    "Plazo:Medio"),

                new Regla("Z3: Préstamo personal -> Plazo CORTO",
                    h => h.Contains("Credito:Personal"),
                    "Plazo:Corto")
            };
        }

          //Motor de inferencia
        private void Motor(List<Regla> reglas, HashSet<string> hechos)
        {
            traza.Clear();
            var disparadas = new HashSet<Regla>();
            bool huboCambios;

            do
            {
                huboCambios = false;

                foreach (Regla r in reglas)
                {
                    if (disparadas.Contains(r)) continue; 

                    if (r.Condicion(hechos))
                    {
                        disparadas.Add(r);
                        hechos.Add(r.Conclusion);          
                        traza.Add("Se disparó: " + r.Nombre);
                        huboCambios = true;                 
                    }
                }
            } while (huboCambios);
        }

        // Busca en los hechos el que empieza con un prefijo (ej. "Credito:") y devuelve solo el valor
        private string ObtenerValor(HashSet<string> hechos, string prefijo)
        {
            foreach (string h in hechos)
            {
                if (h.StartsWith(prefijo))
                    return h.Substring(prefijo.Length);
            }
            return "";
        }



        // Convierte lo que el usuario ingresó en hechos. Devuelve null si el ingreso no es válido.
        private HashSet<string> CapturarHechos()
        {
            // Acepta "50000", "50,000" o "50000.50"
            string texto = txtIngresos.Text.Replace(",", "").Replace("L", "").Trim();
            decimal ingreso;

            if (!decimal.TryParse(texto, NumberStyles.Number, CultureInfo.InvariantCulture, out ingreso) || ingreso < 0)
            {
                MessageBox.Show("Ingrese un ingreso mensual válido (solo números).", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            var hechos = new HashSet<string>();

            if (ingreso > 50000) hechos.Add("ingreso_alto");    
            else if (ingreso >= 25000) hechos.Add("ingreso_medio");    
            else hechos.Add("ingreso_bajo");     

            if (chkEmpleoPermanente.Checked) hechos.Add("empleo_permanente");
            if (chkAtrasos.Checked) hechos.Add("atrasos");

            return hechos;
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            HashSet<string> hechos = CapturarHechos();
            if (hechos == null) return;

            Motor(reglas, hechos);

            txtCapacidad.Text = ObtenerValor(hechos, "Capacidad:");
            txtHistorial.Text = ObtenerValor(hechos, "Historial:");
            txtCliente.Text = ObtenerValor(hechos, "Cliente:");
            txtCredito.Text = ObtenerValor(hechos, "Credito:");
            txtPlazo.Text = ObtenerValor(hechos, "Plazo:");
            txtTraza.Text = string.Join(Environment.NewLine, traza);

            MessageBox.Show("Tipo de cliente: " + txtCliente.Text + Environment.NewLine +
                            "Crédito: " + txtCredito.Text + Environment.NewLine +
                            "Plazo recomendado: " + txtPlazo.Text,
                            "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIngresos.Clear();
            chkEmpleoPermanente.Checked = false;
            chkAtrasos.Checked = false;
            txtCapacidad.Clear();
            txtHistorial.Clear();
            txtCliente.Clear();
            txtCredito.Clear();
            txtPlazo.Clear();
            txtTraza.Clear();
        }
    }
}