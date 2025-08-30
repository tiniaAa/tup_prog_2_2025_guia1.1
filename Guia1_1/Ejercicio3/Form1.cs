using Ejercicio3.Models;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        Peaje peaje = new Peaje();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarPeaje_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                int dia = Convert.ToInt32(form2.numericUpDown1.Value);
                int cantAuto = Convert.ToInt32(form2.textBox1.Text);

                peaje.RegistrarResumenDia(dia, cantAuto);



            }


        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            lbVer.Items.Clear();

            lbVer.Items.Add("Los días en que ingresaron más autos que el promedio en el mes:");
            int[] dias = peaje.CalcularLosDiasMayoresAlPromedio(out int cantDias);

            for (int n = 0; n < cantDias; n++)
            {
                lbVer.Items.Add($"{dias[n]} (cantidad: {peaje.VerCantidadAutosEnUnDia(dias[n])})");
            }

            lbVer.Items.Add("¿Cuál de los tercios del mes tuvo mayor movimiento?");
            int tercio = peaje.CalcularTercioDelMesMayor();

            lbVer.Items.Add(tercio);


        }
    }
}
