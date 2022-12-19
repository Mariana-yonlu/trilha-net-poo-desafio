namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memória) : base(numero, modelo, imei, memória)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("instalando Nokia Wireless");
        }
    }
}