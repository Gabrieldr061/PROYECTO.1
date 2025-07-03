namespace PROYECTO
{
    internal class Program
    {
        public class Ente
        {
            public int id;
            public string name;
            public float peso;
            public float altura;

            public void Presentarse()
            {

            }

            public void Presentarse(string nombre)   //parametro dentro del parentesis
            {
                Console.WriteLine(" Hola soy {0} y mi id es {1} mi peso es {2}kg y mi altura es {3} m", name, id, peso, altura);  //argumentos y atributos no es lo mismo
            }

            public void Presentarse(string nombre, int id)
            {
                Console.WriteLine("Mi nombre es {0} y mi id es {1}", nombre, id);
            }

            public void hablar() {
                Console.WriteLine("estoy hablando ahora mismo");
            }
        }
        static void Main(string[] args)
        {
            Ente ente2 = new Ente();
            ente2.id = 50;
            ente2.altura = 1.90f;
            ente2.peso = 75.5f;
            ente2.name = "Emilio";
            ente2.Presentarse("Emilio");
            
            Ente ente3 = new Ente();
            ente3.id = 100;
            ente3.altura = 1.80f;
            ente3.peso = 80.0f;
            ente3.name = "Alejandro";
            ente3.Presentarse("Alejandro", 100);

            ente2.Presentarse("Angel");
            ente2.hablar();

        }
    }
}
