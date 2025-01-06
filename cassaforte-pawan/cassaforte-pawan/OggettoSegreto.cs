using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cassaforte_pawan
{
    public class OggettoSegreto
    {
        public float ValoreDichiarato { get; set; }

        public virtual float CalcolaValoreAssicurato()
        {
            return ValoreDichiarato;
        }
        public virtual float GetValoreAssicuratoOggetto()
        {
            return ValoreDichiarato;
        }
        public string Tipo { get; set; }
    }

}
