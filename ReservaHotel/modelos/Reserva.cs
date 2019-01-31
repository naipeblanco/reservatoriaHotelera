using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaHotel.modelos
{
    class Reserva
    {
        private int id;
        private String pago ;
        private DateTime fechaEnt;
        private DateTime fechaSal;
        private int dni;

        public int getId()
        {
            return id;
        }

        public void setId(int _id)
        {
            //esto es el set.
            this.id = _id;
        }
        /*-----------------------------*/
        public int getDni()
        {
            return dni;
        }

        public void setDni(int _dni)
        {
            //esto es el set.
            this.dni = _dni;
        }
        /*-----------------------------*/
        public DateTime getFechaEnt()
        {
            return fechaEnt;
        }

        public void setFechaEnt(DateTime _fechaEnt)
        {
            //esto es el set.
            this.fechaEnt = _fechaEnt;
        }
        /*-----------------------------*/
        public DateTime getFechaSal()
        {
            return fechaSal;
        }

        public void setFechaSal(DateTime _fechaSal)
        {
            //esto es el set.
            this.fechaSal = _fechaSal;
        }
        /*----------------------------*/
        public String getPago()
        {
            return pago;
        }

        public void setPago(String _pago)
        {
            //esto es el set.
            this.pago = _pago;
        }

    }
}
