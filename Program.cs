using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia:");
Console.WriteLine("--------------------");
Smartphone nokia = new Nokia(numero: "91011", modelo: "Modelo x", imei: "12345", memoria: 555);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.ReceberLigacao();

Console.WriteLine();

Console.WriteLine("Smartphone Iphone:");
Console.WriteLine("--------------------");
Smartphone iphone = new Iphone(numero: "8910", modelo: "Modelo y", imei: "54321", memoria: 444);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
iphone.ReceberLigacao();
