using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Persona
    {
        //Se usa el recurso de acceder a las variables de datos para poder mostrar
        //Los valores en el datagridview. No acepta valores de la estructura
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        private Datos datos;
        private struct Datos
        {
            public string nombre;
            public string apellido;
            public int edad;
            public string telefono;
            public string direccion;

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
                this.telefono = "";
                this.direccion = direccion;
            }
        }
        public Persona(string nombre, string apellido, int edad, string telefono, string direccion)
        {
            datos = new Datos(nombre, apellido, edad, telefono, direccion);
            bindDatos();
        }
        public Persona(string nombre, string apellido, int edad, string direccion)
        {
            datos = new Datos(nombre, apellido, edad, direccion);
            bindDatos();
        }
        private void bindDatos()
        {
            Nombre = datos.nombre;
            Apellido = datos.apellido;
            Edad = datos.edad;
            Telefono = datos.telefono;
            Direccion = datos.direccion;
        }
    }
}
