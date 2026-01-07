namespace AnimalNamespace
{
    public class Animal
    {
        private string especie;
        private int edad;
        private float peso;

        public Animal(string xespecie, int xedad, float xpeso)
        {
            this.especie = xespecie;
            this.edad = xedad;
            this.peso = xpeso;
        }

        public string Especie
        {
            get { return especie; }
            set { especie = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public float Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public virtual void HacerSonido()
        {
            Console.WriteLine("El animal hace un sonido.");
        }
    }
}