using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cassaforte_pawan
{
    public class Chiave : OggettoSegreto
    {
        public Chiave()
        {
            Tipo = "Chiave";
        }

        public override float CalcolaValoreAssicurato()
        {
            return ValoreDichiarato * 1000;
        }
    }

}
