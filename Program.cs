using System.ComponentModel;
using DesafioPOO.Models;

Console.WriteLine("Instalando smartfone Iphone...");

Smartphone iphone_15 = new Iphone(numero: "99998877", modelo: "iphone 15", imei: "A45BX45", memoria: 128);

iphone_15.Ligar();
iphone_15.InstalarAplicativo("APP do banco");

Console.WriteLine("\n\n");

Console.WriteLine("Instalando smartfone Nokia...");

Smartphone nokia_1020 = new Nokia(numero: "99998877", modelo: "iphone 15", imei: "A45BX45", memoria: 128);

nokia_1020.Ligar();
nokia_1020.InstalarAplicativo("APP delivery");