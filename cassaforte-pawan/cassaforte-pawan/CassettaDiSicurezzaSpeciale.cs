using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cassaforte_pawan
{
    public class CassettaDiSicurezzaSpeciale : CassettaDiSicurezza
    {
        public CassettaDiSicurezzaSpeciale(string pin) : base(pin) { }

        public override float GetValoreAssicuratoOggetto()
        {
            float valore = base.GetValoreAssicuratoOggetto();
            if (valore == 0)
                return 0;

            if (GetTipoOggetto() == "Gioiello Prezioso")
                return valore * 0.9f; // 10% meno
            else if (GetTipoOggetto() == "Documento Legale")
                return valore * 0.8f; // 20% meno
            else if (GetTipoOggetto() == "Chiave")
                return valore * 0.7f; // 30% meno

            return valore;
        }
    }

}
