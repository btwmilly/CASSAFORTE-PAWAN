namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private CassettaDiSicurezza c1;
        private CassettaDiSicurezza c2;
        private CassettaDiSicurezza c3;
        public Form1()
        {
            InitializeComponent();
            CassettaDiSicurezza c1 = new CassettaDiSicurezza("cassetta1", "00000");
            CassettaDiSicurezza c2 = new CassettaDiSicurezza("cassetta2", "11111");
            CassettaDiSicurezza c3 = new CassettaDiSicurezza("cassetta3", "22222");
        }

        private void button1_Click(object sender, EventArgs e)
        {


            c1.InserisciOggetto(new GioielloPrezioso("gioiello1", 100), "00000");
            label1.Text = c1.CodiceSeriale + " " + c1.getTipologia() + " " + c1.getValoreAssicurato() + " " + c1.getValoreDichiarato();

            MessageBox.Show(c1.CodiceSeriale + " " + c1.getTipologia() + " " + c1.getValoreAssicurato() + " " + c1.getValoreDichiarato());

            //CassettaDiSicurezza c4 = new CassettaDiSicurezzaSpeciale("cassetta4", "33333");
        }

        private void inserisciDocumento_Click(object sender, EventArgs e)
        {
            c2.InserisciOggetto(new DocumentoLegale("documento1", 50), "11111");
            label1.Text = c2.CodiceSeriale + " " + c2.getTipologia() + " " + c2.getValoreAssicurato() + " " + c2.getValoreDichiarato();
        }

        private void inserisciChiave_Click(object sender, EventArgs e)
        {
            c3.InserisciOggetto(new ChiaveDiAccesso("chiave1", 10), "22222");
            label1.Text = c3.CodiceSeriale + " " + c3.getTipologia() + " " + c3.getValoreAssicurato() + " " + c3.getValoreDichiarato();
        }
    }
}
