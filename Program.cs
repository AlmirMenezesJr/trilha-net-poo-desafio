using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

System.Console.WriteLine("Smartphne Nokia: ");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo1", imei: "11111111", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

System.Console.WriteLine("/n");

System.Console.WriteLine("Smartphne Iphone: ");
Smartphone iphone = new Iphone(numero:"4987", modelo: "Modelo 2", imei: "22222222", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");