using DesafioPOO.Models;

Nokia nokia = new Nokia(numero: "123456789", modelo: "Nokia 1320", imei: "123456789012345", memoria: "16GB");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Iphone iphone = new Iphone(numero: "987654321", modelo: "iPhone 13", imei: "987654321098765", memoria: "128GB");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
