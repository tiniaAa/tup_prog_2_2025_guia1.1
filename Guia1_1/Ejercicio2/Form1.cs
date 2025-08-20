using Ejercicio2.Models;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        Viaje viaje;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gbFinalizar.Enabled = false;
        }

        private void btnINICIAR_Click(object sender, EventArgs e)
        {
            Form3 Inicio = new Form3();

            if (Inicio.ShowDialog() == DialogResult.OK)
            {
                int HInicio = Convert.ToInt32(Inicio.tbIniciarH.Text);
                int MInicio = Convert.ToInt32(Inicio.tbIniciarM.Text);
                int Asientos = Convert.ToInt32(Inicio.tbAsientos.Text);

                viaje = new Viaje(HInicio, MInicio, Asientos);

                gbFinalizar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se a podido inicar el viaje ");
            }

        }

        private void btnPARADAR_Click(object sender, EventArgs e)
        {
            Form2 Parada = new Form2();
            if (viaje.Ocupados < viaje.Asientos)
            {
                if (Parada.ShowDialog() == DialogResult.OK)
                {
                    int llegadaH = Convert.ToInt32(Parada.tbHH.Text);
                    int salidaH = Convert.ToInt32(Parada.tbMMsalida.Text);
                    int llegadaM = Convert.ToInt32(Parada.tbMM.Text);
                    int SalidaM = Convert.ToInt32(Parada.tbHHsalida.Text);

                    int Ascienden = Convert.ToInt32(Parada.tbAscienden.Text);
                    int Descienden = Convert.ToInt32(Parada.tbDescienden.Text);

                    //bool correctohLL = llegadaH >= 0 && llegadaH <= 23;
                    //if (correctohLL == false)
                    //{
                    //    MessageBox.Show("Valor de Hora incorrecta - el valor es de 0 a 23");
                    //}

                    //bool correctomLL = llegadaM >= 0 && llegadaM <= 59;
                    //if (correctomLL == false)
                    //{
                    //    MessageBox.Show("Valor de Minutos incorrecto - el valor es de 0 a 59");
                    //}

                    //bool correctohS = salidaH >= 0 && salidaH <= 23;
                    //if (correctohS == false)
                    //{
                    //    MessageBox.Show("Valor de Hora incorrecta - el valor es de 0 a 23");
                    //}

                    //bool correctomS = SalidaM >= 0 && SalidaM <= 59;
                    //if (correctomS == false)
                    //{
                    //    MessageBox.Show("Valor de Minutos incorrecto - el valor es de 0 a 59");
                    //}



                    //if (Descienden > 0 || viaje.CantParadas != 0)
                    //{
                        //if (correctohLL && correctomLL && correctohS && correctomS)
                        //{
                            viaje.RealizarParada(llegadaH, llegadaM, salidaH, SalidaM, Ascienden, Descienden);
                    
                        //}
                        //}
                        //else
                        //{
                        //MessageBox.Show("Hubo un error en el ingreso de datos! vuelva a intentarlo.");
                        //}

                }
                else
                {
                    MessageBox.Show("Se cancelo la carga de parada ");
                }

            }
            else
            {
                MessageBox.Show("Todos los asientos estan ocupados no pueden ingresar mas pasajeros ");
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Form4 mostrarInforme = new Form4();

            int finHH = Convert.ToInt32(tbHH.Text);
            int finMM = Convert.ToInt32(tbMM.Text);

            bool correctoh = finHH >= 0 && finHH <= 23;
            if (correctoh == false)
            {
                MessageBox.Show("Valor de Hora incorrecta - el valor es de 0 a 23");
            }

            bool correctom = finMM >= 0 && finMM <= 59;
            if (correctom == false)
            {
                MessageBox.Show("Valor de Minutos incorrecto - el valor es de 0 a 59");
            }

            if (correctom && correctom)
            {
                viaje.Finalizar(finHH,finMM);
                mostrarInforme.lbxInforme.Items.Clear();
                mostrarInforme.lbxInforme.Items.Add($"Cantidad de pasajeros transportados: {viaje.Transportados}");
                mostrarInforme.lbxInforme.Items.Add($"Tiempo total del recorrido {viaje.HDuracionViaje}:{viaje.MDuracionViaje}");
                mostrarInforme.lbxInforme.Items.Add($"Cantidad de paradas {viaje.CantParadas}");
                mostrarInforme.lbxInforme.Items.Add($"tiempo total de demora en paradas {viaje.HDemora}:{viaje.MDemora}");
                mostrarInforme.lbxInforme.Items.Add($"");

                mostrarInforme.ShowDialog();

                btnINICIAR.Enabled = false;
                btnPARADAR.Enabled = false;

            }




        }
    }
}
