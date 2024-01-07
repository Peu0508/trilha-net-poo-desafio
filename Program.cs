using DesafioPOO.Models;

// Realizando os testes com as classes Nokia e Iphone

Console.WriteLine("Testando o Nokia:");
Smartphone nokia = new Nokia(numero: "123456789",modelo: "Modelo 1", imei:"1111",memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Testando o iPhone:");
Smartphone iphone = new Iphone(numero: "987654321",modelo: "Modelo 2", imei:"2222",memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

