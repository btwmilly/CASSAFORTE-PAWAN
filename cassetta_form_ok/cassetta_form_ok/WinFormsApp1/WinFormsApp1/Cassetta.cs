using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{

    class OggettoSegreto
    {

        private string identificatore;
        public string Identificatore
        {
            get { return identificatore; }
        }
        private double valoreDichiarato;
        public double ValoreDichiarato
        {
            get { return valoreDichiarato; }
        }
        virtual public double CalcolaValoreAss()
        { return valoreDichiarato; }
        public OggettoSegreto(string identificatore, double valoreDichiarato)
        {
            this.identificatore = identificatore;
            this.valoreDichiarato = valoreDichiarato;
        }

    }

    class GioielloPrezioso : OggettoSegreto
    {
        public GioielloPrezioso(string identificatore, double valoreDichiarato) : base(identificatore, valoreDichiarato)
        {
        }

        override public double CalcolaValoreAss()
        {
            return base.CalcolaValoreAss() * 5;
        }
    }

    class DocumentoLegale : OggettoSegreto
    {
        public DocumentoLegale(string identificatore, double valoreDichiarato) : base(identificatore, valoreDichiarato)
        {
        }

        override public double CalcolaValoreAss()
        {
            if (ValoreDichiarato >= 100)
            {
                return ValoreDichiarato;
            }
            else
            {
                return 50;
            }
        }
    }

    class ChiaveDiAccesso : OggettoSegreto
    {
        public ChiaveDiAccesso(string identificativo, double valoreDichiarato) : base(identificativo, valoreDichiarato)
        {
        }

        override public double CalcolaValoreAss()
        {
            return base.CalcolaValoreAss() * 1000;
        }
    }

    class CassettaDiSicurezza
    {
        private string? codiceSeriale;
        public string? CodiceSeriale
        {
            get { return codiceSeriale; }
            protected set { codiceSeriale = value; }
        }
        private OggettoSegreto oggetto;
        public OggettoSegreto Oggetto
        {
            get { return oggetto; }
        }
        private string pin;
        protected string Pin
        {
            get { return pin; }
        }

        public CassettaDiSicurezza(string codiceSeriale, string pin, OggettoSegreto oggetto)
        {
            this.codiceSeriale = codiceSeriale;
            this.pin = pin;
            this.oggetto = oggetto;
        }

        public CassettaDiSicurezza(string codiceSeriale, string pin):this(codiceSeriale,pin,null)
        {
        }




        public void InserisciOggetto(OggettoSegreto oggetto, string pin)
        {
            if (this.pin == pin && oggetto != null)
            {
                this.oggetto = oggetto;
            }
        }
        public string getTipologia()
        {
            if (this.oggetto != null)
                return oggetto.GetType().ToString();
            else
                return "nessun oggetto presente ";
        }
        //oggetto is GioielloPrezioso
        //oggetto is OggettoSegreto
        //typeof oggetto 




        public OggettoSegreto RimuoviOggetto(string pin)
        {
            OggettoSegreto o = null;
            if (this.pin == pin && this.oggetto != null)
            {
                o = this.oggetto;
                this.oggetto = null;
            }
            return o;
        }
        public double getValoreDichiarato()
        {
            if (this.oggetto != null)
                return oggetto.ValoreDichiarato;
            else
                return 0;
        }
        public double getValoreAssicurato()
        {
            if (this.oggetto != null)
                return oggetto.CalcolaValoreAss();
            else
                return 0;

        }

    }
     class CassettaDiSicurezzaSpeciale : CassettaDiSicurezza
    {
        public CassettaDiSicurezzaSpeciale(string codiceSeriale, string pin, OggettoSegreto oggetto):base(codiceSeriale,pin, oggetto) 
        {

        }
        public CassettaDiSicurezzaSpeciale(string codiceSeriale, string pin) : this(codiceSeriale, pin, null)
        {
        }
    }
}
