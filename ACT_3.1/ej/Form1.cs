using ej.Models;

namespace ej
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Granja granja;
        int dias = 1;
        private void btnSimularDia_Click(object sender, EventArgs e)
        {
            granja = new Granja();
            lsbSimular.Items.Add($"Dia {dias}");
            List<string> acciones = new List<string>();
            acciones = granja.SimularDia();
            foreach (string accion in acciones)
            {
                lsbSimular.Items.Add(accion);
            }
            dias++;
        }
    }
}
