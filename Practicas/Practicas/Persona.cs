using System;

namespace Practicas
{
    class Persona
    {
        Datos datos;
        struct Datos
        {
            private string nombre;
            private string apellido;
            private int edad;
            private string telefono;
            private string direccion;

            public Datos(string nombre, string apellido, int edad, string telefono, string direccion)
            {
                this.nombre = nombre;
                this.apellido = apellido;
                this.edad = edad;
                this.telefono = telefono;
                this.direccion = direccion;
            }
            public Datos(string nombre, string apellido, int edad, string direccion)
            {
                this.nombre = nombre;
                this.apellido = apellido;
                this.edad = edad;
                this.telefono = null;
                this.direccion = direccion;
            }
        }
        public Persona(string nombre, string apellido, int edad, string telefono, string direccion)
        {
            datos = new Datos(nombre, apellido, edad, telefono, direccion);
        }
        public Persona(string nombre, string apellido, int edad, string direccion)
        {
            datos = new Datos(nombre, apellido, edad, direccion);
        }
    }
}
