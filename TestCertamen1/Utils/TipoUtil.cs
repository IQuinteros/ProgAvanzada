using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCertamen1.Utils
{
    public enum ETipo
    {
        Alfa1,
        Beta1
    }

    public enum ESubTipo
    {
        Tetraedo,
        Piramidal,
        Nuclear,
        Bipolar
    }

    public static class TipoUtil
    {
        public static string[] GetTiposAsString()
        {
            string[] toReturn = { ETipo.Alfa1.ToString(), ETipo.Beta1.ToString() };
            return toReturn;
        }

        public static string[] GetSubTiposAsString()
        {
            string[] toReturn = { 
                ESubTipo.Tetraedo.ToString(), 
                ESubTipo.Piramidal.ToString(),
                ESubTipo.Nuclear.ToString(),
                ESubTipo.Bipolar.ToString(),
            };
            return toReturn;
        }

        public static string[] GetSubTiposAsString(List<ESubTipo> subtiposList)
        {
            List<string> toReturn = new List<string>();
            subtiposList.ForEach((subtipo) =>
            {
                toReturn.Add(subtipo.ToString());
            });

            return toReturn.ToArray();
        }

        public static ETipo GetTipoFromString(string tipoString)
        {
            return tipoString.Equals(ETipo.Alfa1.ToString()) ? ETipo.Alfa1 : ETipo.Beta1;
        }

        public static ESubTipo GetSubTipoFromString(string subtipoString)
        {
            if (subtipoString.Equals(ESubTipo.Bipolar.ToString()))
            {
                return ESubTipo.Bipolar;
            }
            else if (subtipoString.Equals(ESubTipo.Nuclear.ToString()))
            {
                return ESubTipo.Nuclear;
            }
            else if (subtipoString.Equals(ESubTipo.Piramidal.ToString()))
            {
                return ESubTipo.Piramidal;
            }
            else
            {
                return ESubTipo.Tetraedo;
            }
        }

        public static List<ESubTipo> GetSubTiposOfTipo(ETipo tipo)
        {
            List<ESubTipo> toReturn = new List<ESubTipo>();

            switch (tipo)
            {
                case ETipo.Alfa1:
                    toReturn.Add(ESubTipo.Tetraedo);
                    toReturn.Add(ESubTipo.Piramidal);
                    return toReturn;
                case ETipo.Beta1:
                    toReturn.Add(ESubTipo.Nuclear);
                    toReturn.Add(ESubTipo.Bipolar);
                    return toReturn;
                default:
                    return toReturn;
            }
        }
    }
}
