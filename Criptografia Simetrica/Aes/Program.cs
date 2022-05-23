using System.Security.Cryptography;
using System.Text;
using System;

RandomNumberGenerator random = RandomNumberGenerator.Create();

byte[] key = new byte[16];
byte[] iv = new byte[16];

random.GetBytes(key);
random.GetBytes(iv);

Aes aes = Aes.Create();
aes.Key = key;
aes.IV = iv;

Console.Write("Digite o texto: ");
var message = Console.ReadLine();
var messageBytes = Encoding.UTF8.GetBytes(message);

Console.Clear();

var encriptedText = aes.EncryptCbc(messageBytes, iv, PaddingMode.PKCS7);
Console.WriteLine($"Mensagem Criptografada: {BitConverter.ToString(encriptedText)}");

var decriptedText = aes.DecryptCbc(encriptedText, iv, PaddingMode.PKCS7);
Console.WriteLine($"Mensagem Original: {Encoding.UTF8.GetString(decriptedText)}");
