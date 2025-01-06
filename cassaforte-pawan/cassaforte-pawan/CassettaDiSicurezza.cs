using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cassaforte_pawan
{
    public class CassettaDiSicurezza
    {
        private OggettoSegreto contenuto;
        private string pin;

        public CassettaDiSicurezza(string pin)
        {
            this.pin = pin;
        }

        public void Inserisci(OggettoSegreto o, string pinInserito)
        {
            if (pinInserito == pin)
            {
                contenuto = o;
            }
            else
            {
                Console.WriteLine("PIN errato!");
            }
        }

        public OggettoSegreto Rimuovi(string pinInserito)
        {
            if (pinInserito == pin)
            {
                OggettoSegreto oggetto = contenuto;
                contenuto = null;
                return oggetto;
            }
            else
            {
                Console.WriteLine("PIN errato!");
                return null;
            }
        }

        public float GetValoreAssicuratoOggetto()
        {
            return contenuto?.CalcolaValoreAssicurato() ?? 0;
        }

        public string GetTipoOggetto()
        {
            return contenuto?.Tipo ?? "Vuota";
        }
    }

}
