namespace PersonaNamespace
{
    class Persona
    {
        private string nombre;
        private int edad;

        public Persona(string xnombre, int xedad)
        {
            this.nombre = xnombre;
            this.edad = xedad;
        }

        public string Nombre
        {
            get => nombre;
            set { nombre = value; }
        }
        
        public int Edad
        {
            get => edad;
            set { edad = value; }
        }
    }
}