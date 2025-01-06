namespace cassaforte_pawan
{
    public partial class Form1 : Form
    {
        private CassettaDiSicurezza cassetta1, cassetta2, cassetta3;
        private CassettaDiSicurezzaSpeciale cassettaSpeciale1, cassettaSpeciale2, cassettaSpeciale3;

        public Form1()
        {
            InitializeComponent();
            cassetta1 = new CassettaDiSicurezza("12345");
            cassetta2 = new CassettaDiSicurezza("12345");
            cassetta3 = new CassettaDiSicurezza("12345");

            cassettaSpeciale1 = new CassettaDiSicurezzaSpeciale("54321");
            cassettaSpeciale2 = new CassettaDiSicurezzaSpeciale("54321");
            cassettaSpeciale3 = new CassettaDiSicurezzaSpeciale("54321");
        }

        private void buttonInserisci_Click(object sender, EventArgs e)
        {
            GioielloPrezioso gp = new GioielloPrezioso();
            gp.ValoreDichiarato = 1000;
            cassetta1.Inserisci(gp, Pin.Text);
            labelValoreAssicurato.Text = "Valore Assicurato: " + cassetta1.GetValoreAssicuratoOggetto();
        }

        private void buttonRimuovi_Click(object sender, EventArgs e)
        {
            OggettoSegreto oggettoRimosso = cassetta1.Rimuovi(Pin.Text);
            if (oggettoRimosso != null)
            {
                cassettaSpeciale1.Inserisci(oggettoRimosso, Pin.Text);

                // Mostra i risultati
                labelTipoOggetto.Text = "Tipo Oggetto (Speciale): " + cassettaSpeciale1.GetTipoOggetto();
                labelValoreAssicurato.Text = "Valore Assicurato (Speciale): " + cassettaSpeciale1.GetValoreAssicuratoOggetto();
            }
        }
    }
}
