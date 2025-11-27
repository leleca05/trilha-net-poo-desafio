using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Testando Nokia");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "Nokia ", imei: "012345", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("Teste Finalizado.\n");

Console.WriteLine("Testando IPhone");
Smartphone iphone = new Iphone(numero: "987654321", modelo: "Iphone ", imei: "098765", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram"); 
