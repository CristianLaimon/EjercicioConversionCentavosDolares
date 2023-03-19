namespace EjercicioConversionCentavosDolares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Programa.HabilitarDeshabilitar(textBox1, textBox2);
        }
    }
}