namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo {get; set;}
        private string IMEI {get; set;}
        private int Memória {get; set;}


        public Smartphone(string numero, string modelo, string imei, int memória)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memória = memória;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}