namespace PROYECTO
{
    public class Clasexd
    {
        //Atributos
        public int id;
        public string name; //si queremos cambiar una variable en todas cntrl + R y clic
        public float peso;
        public bool estado;

        //Metodos
        public void Presentarse()
        {
            Console.WriteLine("Hola mi nombre es {0}", name);
        }

        public void Brincar()
        {
            Console.WriteLine("Mirame estoy brincando");
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Clasexd ente = new Clasexd();
                ente.id = 1;
                ente.name = "Angel";
                ente.peso = 12.25f;
                ente.estado = true;

                ente.Presentarse();
            }
        }
    }
}
