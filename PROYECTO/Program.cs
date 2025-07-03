namespace PROYECTO
{
    internal class Program
    {

        public class valorant {
            public string rango;
            public int ID;
            public int nivel;

            public valorant(string rango, int ID, int nivel)
            {
                this.rango = rango;
                this.ID = ID;
                this.nivel = nivel;
            }

            public void mostrar()
            {
                Console.WriteLine("Rango: " + rango);
                Console.WriteLine("ID: " + ID);
                Console.WriteLine("Nivel: " + nivel);
            }
        } 
        static void Main(string[] args)
        {
            
            valorant jugador = new valorant("Oro", 12345, 10);
            jugador.mostrar();

        }
    }
}
