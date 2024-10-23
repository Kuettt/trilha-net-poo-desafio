using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone");
Iphone iphone = new Iphone(numero:"123456", modelo:"Modelo 1", imei:"12345678910", memoria:50);
iphone.Ligar();
iphone.InstalarAplicativo(nomeApp:"Telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia(numero:"6543210", modelo:"Modelo 4.5", imei: "548423482", memoria:100);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");
