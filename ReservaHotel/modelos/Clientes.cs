using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaHotel.modelos
{
    class Clientes
    {
        private int dni;
        private String nombre;
        private String apellido;
        private int telefono;

        public int getDni()
        {
            return dni;
        }

        public void setDni(int _dni)
        {
            //esto es el set.
            this.dni = _dni;
        }
        /*----------------------*/
        public String getNombre()
        {
            return nombre;
        }

        public void setNombre(String _nombre)
        {
            //esto es el set.
            this.nombre = _nombre;
        }
        /*----------------------*/
        public String getApellido()
        {
            return apellido;
        }

        public void setApellido(String _apellido)
        {
            //esto es el set.
            this.apellido = _apellido;
        }
        /*-----------------------*/
        public int getTelefono()
        {
            return telefono;
        }

        public void setTelefono(int _telefono)
        {
            //esto es el set.
            this.telefono = _telefono;
        }

    }
}
