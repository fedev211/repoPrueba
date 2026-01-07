namespace AutoNamespace
{
    public class Auto
    {
        private string marca;
        private string patente;
        private int año;
        private string color;
        private float precio;

        public Auto(string xmarca, string xpatente, int xaño, string xcolor, float xprecio)
        {
            this.marca = xmarca;
            this.patente = xpatente;
            this.año = xaño;
            this.color = xcolor;
            this.precio = xprecio;
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Patente
        {
            get { return patente; }
            set { patente = value; }
        }

        public int Año
        {
            get { return año; }
            set { año = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }







































    }
}