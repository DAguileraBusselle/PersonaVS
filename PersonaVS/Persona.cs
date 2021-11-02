using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaVS
{
    class Persona
    {
        private String nombre;
        private String ape1;
        private String ape2;
        private String dni;
        private int id;

        public Persona(string nombre, string ape1, string ape2, string dni, int id)
        {
            this.nombre = nombre;
            this.ape1 = ape1;
            this.ape2 = ape2;
            this.dni = dni;
            this.id = id;
        }

        public String getNombre()
        {
            return nombre;
        }

        public String getApe1()
        {
            return ape1;
        }

        public String getApe2()
        {
            return ape2;
        }

        public String getDni()
        {
            return dni;
        }

        public int getID()
        {
            return id;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public void setApe1(String ape1)
        {
            this.ape1 = ape1;
        }

        public void setApe2(String ape2)
        {
            this.ape2 = ape2;
        }

        public void setDni(String dni)
        {
            this.dni = dni;
        }




    }
}
