namespace idade
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dataNas = dateTimePicker1.Value;
            int idade = DateTime.Today.Year - dataNas.Year;
            int diaNas = dataNas.DayOfYear;
            int mesNas = DateTime.Now.Month;
            int diaAtual = DateTime.Today.DayOfYear;
            int mesAtual = DateTime.Now.Month;
            
            if (mesNas > mesAtual || (mesNas == mesAtual && diaNas > diaAtual))
            {
                idade--;
            }

            label1.Text = "A sua idade é: " + idade + " anos.";
            
        }

                 private void label1_Click(object sender, EventArgs e)
                 {

                 }

        
    }
}