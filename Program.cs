using DesafioPOO.Models;

Nokia nokia = new Nokia("123456789", "Nokia 1210", "123456789012345", "16GB");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Iphone iphone = new Iphone("987654321", "iPhone 13", "987654321098765", "128GB");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
