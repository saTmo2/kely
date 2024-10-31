using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private int puntaje = 0;
        private int preguntaActual = 0;

        // Preguntas de selección múltiple
        private string[] preguntas = {
            "¿Cuál es la comida favorita de Santiago?",
            "¿Cuál es el tamaño de la verga de Santi?",
            "¿Cuál es la moto de Santi?",
            "¿Quién es la suegra?",
            "¿Cuál es el mejor pasatiempo?"
        };

        // Opciones de selección múltiple
        private string[,] opciones = {
            { "todas las anteriores", "frijoles", "hamburguesa", "perro" },
            { "3", "16", "5", "11" },
            { "kaffir", "boxer ct 1200r", "SZ-r 150", "nkFir" },
            { "adelaida osorio", "glenis marin", "martha", "tereza pino" },
            { "pasar tiempo con santi", "sexo", "gum a muerte", "comer" }
        };

        // Respuestas correctas para selección múltiple
        private int[] respuestasCorrectas = { 0, 1, 2, 0, 0 };

        // Preguntas de verdadero y falso
        private string[] preguntasVF = {
            "¿La Tierra es plana?", // Pregunta de verdadero/falso
            "¿El agua es líquida a temperatura ambiente?" // Pregunta de verdadero/falso
        };

        // Respuestas correctas para verdadero/falso
        private bool[] respuestasVerdaderas = { false, true };

        public Form2()
        {
            InitializeComponent();
            CargarPregunta();
        }

        private void CargarPregunta()
        {
            // Verificar si hay más preguntas de selección múltiple
            if (preguntaActual < preguntas.Length)
            {
                lblPregunta.Text = preguntas[preguntaActual];
                rbOpcion1.Visible = true;
                rbOpcion2.Visible = true;
                rbOpcion3.Visible = true;
                rbOpcion4.Visible = true;

                rbOpcion1.Text = opciones[preguntaActual, 0];
                rbOpcion2.Text = opciones[preguntaActual, 1];
                rbOpcion3.Text = opciones[preguntaActual, 2];
                rbOpcion4.Text = opciones[preguntaActual, 3];

                // Ocultar botones de verdadero y falso
                rbVerdadero.Visible = false;
                rbFalso.Visible = false;
            }
            // Verificar si hay más preguntas de verdadero/falso
            else if (preguntaActual - preguntas.Length < preguntasVF.Length)
            {
                lblPregunta.Text = preguntasVF[preguntaActual - preguntas.Length];

                // Ocultar opciones de selección múltiple
                rbOpcion1.Visible = false;
                rbOpcion2.Visible = false;
                rbOpcion3.Visible = false;
                rbOpcion4.Visible = false;

                // Mostrar botones de verdadero y falso
                rbVerdadero.Visible = true;
                rbFalso.Visible = true;

                rbVerdadero.Text = "Verdadero";
                rbFalso.Text = "Falso";
            }
            else
            {
                MessageBox.Show($"Juego terminado. Tu puntaje final es: {puntaje}");
                this.Close();
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int respuestaSeleccionada = -1;

            // Obtener respuesta de selección múltiple
            if (rbOpcion1.Visible && rbOpcion1.Checked) respuestaSeleccionada = 0;
            else if (rbOpcion2.Visible && rbOpcion2.Checked) respuestaSeleccionada = 1;
            else if (rbOpcion3.Visible && rbOpcion3.Checked) respuestaSeleccionada = 2;
            else if (rbOpcion4.Visible && rbOpcion4.Checked) respuestaSeleccionada = 3;

            // Verificar respuesta de selección múltiple
            if (respuestaSeleccionada != -1 && preguntaActual < preguntas.Length && respuestaSeleccionada == respuestasCorrectas[preguntaActual])
            {
                puntaje++;
            }
            // Verificar respuesta de verdadero/falso
            else if (preguntaActual >= preguntas.Length && preguntaActual - preguntas.Length < preguntasVF.Length)
            {
                if (rbVerdadero.Checked && respuestasVerdaderas[preguntaActual - preguntas.Length])
                {
                    puntaje++;
                }
                else if (rbFalso.Checked && !respuestasVerdaderas[preguntaActual - preguntas.Length])
                {
                    puntaje++;
                }
            }

            preguntaActual++;
            CargarPregunta();
            lblPuntaje.Text = $"Puntaje: {puntaje}";
        }
    }
}

