using Sistema_Celular_Dio.models;
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "44988290660", modelo: "007", imei: "066009288944", memoria: 528);
nokia.Ligar();
nokia.InstalarAplicativo("Clash Royale");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "44998797989", modelo: "14 Pro", imei: "989789944", memoria: 1024);
iphone.Ligar();
iphone.InstalarAplicativo("tinder");
