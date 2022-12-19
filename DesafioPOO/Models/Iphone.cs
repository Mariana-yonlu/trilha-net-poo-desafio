namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memória) : base(numero, modelo, imei, memória)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("instalando Launcher IOS");
        }
    }
}