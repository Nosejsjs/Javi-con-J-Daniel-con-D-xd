using System;
namespace ultimacosadejavi
{
    class persona
    {
        private string nombre;
        private string apellido;
        private int edad;
        private int altura;

        public persona(string nombre, string apellido, int edad, int altura)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.altura = altura;
        }

        public string todoelnombre()
        {
            return nombre + " " + apellido;
        }
        public double alturaenm()
        {
            return altura / 100.00;
        }
        public void imprimirdata()
        {
            Console.WriteLine("Nombre completo: " + todoelnombre());
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Altura: " + alturaenm() + "m");
        }

    }
    class persona1
    {
        static void Main()
        {
            persona persona = new persona("Daniel","del Cid", 18, 181 );
            persona.imprimirdata();
        }
    }
}