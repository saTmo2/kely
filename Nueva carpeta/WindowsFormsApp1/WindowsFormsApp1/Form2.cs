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

        private string[] preguntas = {
            "¿Cuál es la comida favorita de santiago?",
            "¿Cuál es el taaño de la verga de santi?",
            "¿Cuál es la moto de santi?",
            "¿Quién es la suegra '?",
            "¿Cuál es el mejor pasatiempo?"
        };

        private string[,] opciones = {
            { "todas las anteriores", "frijoles", "hamburguesa", "perro" },
            { "3", "16", "5", "11" },
            { "kaffir", "boxer ct 1200r", "SZ-r 150", "nkFir" },
            { "adelaida osorio", "glenis marin", "martha ", "tereza pino" },
            { "pasar tiempo con santi", "sexo", "gum aa muerte ", "comer " }
        };

        private int[] respuestasCorrectas = { 0, 1, 2, 0, 0 }; 

        public Form2()
        {
            InitializeComponent();
            CargarPregunta();
        }

        private void CargarPregunta()
        {
            if (preguntaActual < preguntas.Length)
            {
                lblPregunta.Text = preguntas[preguntaActual];
                rbOpcion1.Text = opciones[preguntaActual, 0];
                rbOpcion2.Text = opciones[preguntaActual, 1];
                rbOpcion3.Text = opciones[preguntaActual, 2];
                rbOpcion4.Text = opciones[preguntaActual, 3];
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

            if (rbOpcion1.Checked) respuestaSeleccionada = 0;
            else if (rbOpcion2.Checked) respuestaSeleccionada = 1;
            else if (rbOpcion3.Checked) respuestaSeleccionada = 2;
            else if (rbOpcion4.Checked) respuestaSeleccionada = 3;

            if (respuestaSeleccionada == respuestasCorrectas[preguntaActual])
            {
                puntaje++;
            }

            preguntaActual++;
            CargarPregunta();
            lblPuntaje.Text = $"Puntaje: {puntaje}";
        }
    }
}
