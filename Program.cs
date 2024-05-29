using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "12345", modelo: "Nokia C2-01", imei: "12121212", memoria: 56);
nokia.Ligar();
nokia.InstalarAplicativo("TikTok");

Console.WriteLine();

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "6789", modelo: "Iphone 15XR", imei: "56565656", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

