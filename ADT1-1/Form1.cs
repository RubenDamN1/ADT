namespace EjercicioADT1_1
{
    public partial class Form1 : Form
    {
        FileStream fs = null;
        String Cadena;
        String rutaDefecto = "C:\\Users\\Ruben Alvarez\\Desktop\\ADT-github\\ADT1-1\\";
        String ruta="";
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            tbRuta.Clear();
            tbNombre.Clear();
            tbFrase.Clear();
        }

        private void btGrabar_Click(object sender, EventArgs e)
        {
            if (tbFrase.Text != "" && tbNombre.Text != "")
            {
                try
                {
                    if (tbRuta.Text == "")
                    {
                        ruta += rutaDefecto + tbNombre.Text + ".txt";
                    }
                    else
                    {
                        ruta += tbRuta.Text + tbNombre.Text + ".txt";
                    }
                    using (fs = new FileStream(ruta, FileMode.OpenOrCreate))
                    {
                        Cadena = tbFrase.Text;
                        Cadena.Trim();
                        for (int i = 0; i < Cadena.Length; i++)
                        {
                            fs.WriteByte((byte)Cadena[i]);
                        }
                        tbRuta.Clear();
                        tbNombre.Clear();
                        tbFrase.Clear();
                        muestraMensaje("Exito al grabar");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                muestraMensaje("Debe introducir algún texto y un nombre de fichero");
            }
        }

        private void muestraMensaje(String mensaje)
        {
            MessageBox.Show(mensaje);
        }
    }


}
