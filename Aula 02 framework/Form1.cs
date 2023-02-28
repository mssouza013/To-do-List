namespace Aula_02_framework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTarefa.Text != "")
            {
                lbxLista.Items.Add($"{dtpPrincipal.Value:d} - {txtTarefa.Text}");
            }else
            {
                MessageBox.Show("Escreva algo!!");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            for (int i = lbxLista.Items.Count - 1; i >= 0; i--)
            {
                // o item está selecionado?
                if (lbxLista.GetSelected(i))
                {
                    lbxLista.Items.RemoveAt(i);
                }
            }
        }
    }
}