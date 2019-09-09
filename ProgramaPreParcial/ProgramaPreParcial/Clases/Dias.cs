using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaPreParcial.Clases
{
    public class Dias
    {
        public string[] Dia = { "lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" };
        public System.String DiasSemana()    // Método que muestra cuales son los días de la semana
        {
            System.String mRespuesta = "Los días de la semana son:\r\n" ;

            for (System.Int32 i = 0; i < 7; i++)
            {
                mRespuesta = mRespuesta + Dia[i] + "\r\n";
            }
            return mRespuesta;
        }

    }
}
