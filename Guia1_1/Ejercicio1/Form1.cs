using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            string marca = tbMarca.Text;
            int modelo = (int)nupModelo.Value;
            int a�oACalcular = (int)nupA�o.Value;
            double valorFabricacion = Convert.ToInt32(tbValor.Text);
            double tasaDepreciacion = Convert.ToDouble(tbTasa.Text);
            int vidaUtil = Convert.ToInt32(tbVidaUtil.Text);

            Moto moto = new Moto(marca, modelo, valorFabricacion);



            Form2 form2 = new Form2();
            form2.tbResultados.ReadOnly = true;


            double valorLineal = moto.CalcularDepreciacionLineal(a�oACalcular, vidaUtil);
            double valorAnual = moto.CalcularDepreciacionAnual(a�oACalcular, tasaDepreciacion);

            form2.tbResultados.Text = @$"{moto.VerDescripcion()}
Depreciaci�n Lineal: ${valorLineal}
Depreciaci�n Anual: ${valorAnual:f2}";
            form2.ShowDialog();

            




        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
