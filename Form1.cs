namespace EjercicioConversionCentavosDolares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Funcionalidades.HabilitarDeshabilitar(textBox1, textBox2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculadora.CalcularDolares((int)numericUpDown1.Value, out int dolares, out int centavosRestantes); //Estoy declarando 2 nuevos valores para guardar los valroes "out" que me regresará el método.
            textBox1.Text = dolares.ToString();
            textBox2.Text = centavosRestantes.ToString();
        }
    }
}