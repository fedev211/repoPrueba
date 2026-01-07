using AnimalNamespace;

namespace PerroNamespace
{
    class Perro : Animal
    {
        private string raza;

        public Perro(string xraza, int xedad, float xpeso) : base("Perro", xedad, xpeso)
        {
            this.raza = xraza;
        }

        public string Raza
        {
            get { return raza; }
            set { raza = value; }
        }

        public override void HacerSonido()
        {
            Console.WriteLine("El perro ladra.");
        }
    }
}