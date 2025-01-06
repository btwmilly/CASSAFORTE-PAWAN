using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cassaforte_pawan
{
    public class DocumentoLegale : OggettoSegreto
    {
        public DocumentoLegale()
        {
            Tipo = "Documento Legale";
        }

        public override float CalcolaValoreAssicurato()
        {
            if (ValoreDichiarato >= 100)
                return ValoreDichiarato;
            return 50;
        }
    }

}
