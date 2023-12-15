using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "(11)91234-5678", modelo: "Nokia X", imei: "123456789", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "(12)98765-4321", modelo: "iPhone Y", imei: "987654321", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");