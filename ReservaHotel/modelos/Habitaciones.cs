using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaHotel.modelos
{
    class Habitaciones
    {
        private int numero;
        private int camaInd;
        private int CamaMatr;
        private String CamaSuple;

        public int getNumero()
        {
            return numero;
        }

        public void setNumero(int _numero)
        {
            //esto es el set.
            this.numero = _numero;
        }

        /*----------------------*/

        public int getCamaInd()
        {
            return camaInd;
        }

        public void setCamaInd(int _camaInd)
        {
            //esto es el set.
            this.camaInd = _camaInd;
        }

        /*----------------------*/

        public int getCamaMatr()
        {
            return CamaMatr;
        }

        public void setCamaMatr(int _camaMatr)
        {
            //esto es el set.  
            this.CamaMatr = _camaMatr;
        }

        /*----------------------*/

        public String getCamaSuple()
        {
            return CamaSuple;
        }

        public void setCamaSuple(String _CamaSuple)
        {
            //esto es el set.
            this.CamaSuple = _CamaSuple;
        }
    }
}
