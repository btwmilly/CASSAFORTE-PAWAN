using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cassaforte_pawan
{
    public class GioielloPrezioso : OggettoSegreto
    {
        public GioielloPrezioso()
        {
            Tipo = "Gioiello Prezioso";
        }

        public override float CalcolaValoreAssicurato()
        {
            return ValoreDichiarato * 5;
        }
    }

}
