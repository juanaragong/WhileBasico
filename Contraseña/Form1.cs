namespace Contraseña
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string contraseña;
            int conteo=0;

            
            while (conteo < 3)
            {
                contraseña = Microsoft.VisualBasic.Interaction.InputBox("Proporciona la contraseña");

                if (contraseña == "jenifer")
                {
                    MessageBox.Show("Bienvenido Marco");
                    break;
                    
                }
                else
                {
                    conteo++;
                    MessageBox.Show("numero de intentos : " + conteo);
                    if (conteo == 3)
                    {
                        MessageBox.Show("Superaste el numero de intentos");
                    }
                }
               
            }
           
        }

    }
    
}
