namespace Clase__POO_
{
    class Auto
    {
        private string matricula;
        private string modelo;
        private string marca;
        private string color;
        private double precio;

        public Auto(string matricula, string modelo, string marca, string color, double precio)
        {
            this.matricula = matricula;
            this.modelo = modelo;
            this.marca = marca;
            this.color = color;
            this.precio = precio;
        }

        public string pMatricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string pMarca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string pModelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public string pColor
        {
            get { return color; }
            set { color = value; }
        }
        public double pPrecio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string toString()
        {
            return "AUTO\nMARTICULA: " + matricula + "\nMODELO: " + modelo + "\nMARACA: " + marca + "\nPRECIO: " + precio.ToString() + "\nCOLOR : " + color;
        }
    }
}
