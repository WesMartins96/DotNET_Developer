



using Projeto_Celular.Models;

Console.WriteLine("CELULAR [NOKIA]");
Smartphone nokia = new Nokia(numero: "112233", modelo: "Nokia X3-00", imei: "111111111", memoria: 24);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine();

Console.WriteLine("CELULAR [IPHONE]");
Smartphone iphone = new Iphone(numero: "332211", modelo: "Iphone 15XR", imei: "111111111", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");


