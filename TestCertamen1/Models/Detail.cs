using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCertamen1.Utils;

namespace TestCertamen1.Models
{
    public class Detail
    {
        public ETipo SelectedTipo { get; }
        public ESubTipo SelectedSubTipo { get; }
        public decimal Gramaje { get; }
        public decimal Result { get; }
        public string Origen { get; }
        public int Humedad { get; }
        public bool UseHumedad { get; }

        public int Energia { get; set; }
        public string Catalizador { get; set; }

        public Detail(ETipo selectedTipo, int humedad, bool useHumedad, decimal gramaje, string origen, decimal result)
        {
            SelectedTipo = selectedTipo;
            Humedad = humedad;
            UseHumedad = useHumedad;
            Gramaje = gramaje;
            Origen = origen;
            Result = result;
        }
    }
}
