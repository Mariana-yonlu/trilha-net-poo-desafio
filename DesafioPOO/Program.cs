using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone");
Iphone  i1 = new Iphone(numero: "(11) 987654321", modelo: "Modelo 7", imei: "000000", memória: 5);

 i1.Ligar();
 i1.ReceberLigacao();
 i1.InstalarAplicativo("dio");

Console.WriteLine("Smartphone Nokia");
Nokia  n1 = new Nokia(numero: "(11) 198765432", modelo: "Modelo NG3", imei: "999999", memória: 10);

n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("dio");
