using System.Security.Cryptography;
using System.Text;

Console.Write("Digite a entrada: ");
var text = Console.ReadLine();
var encodedText =new ASCIIEncoding().GetBytes(text);

var desAlgorithm = DES.Create();
desAlgorithm.GenerateKey();
desAlgorithm.GenerateIV();

//Encript

var memoryStreamWrite = new MemoryStream();
var criptoStreamWrite = new CryptoStream(memoryStreamWrite, desAlgorithm.CreateEncryptor(desAlgorithm.Key, desAlgorithm.IV), CryptoStreamMode.Write);
criptoStreamWrite.Write(encodedText, 0, encodedText.Length);
criptoStreamWrite.FlushFinalBlock();

var encryptedBytes = memoryStreamWrite.ToArray();
Console.WriteLine($"Chave usada: {BitConverter.ToString(desAlgorithm.Key)}");
Console.WriteLine($"Dado criprografado: {BitConverter.ToString(encryptedBytes)}");

//Descript

var memoryStreamRead = new MemoryStream(encryptedBytes);
var criptoStreamRead = new CryptoStream(memoryStreamRead, desAlgorithm.CreateDecryptor(desAlgorithm.Key, desAlgorithm.IV), CryptoStreamMode.Read);
byte[] fromEncrypt = new byte[encryptedBytes.Length];
criptoStreamRead.Read(fromEncrypt, 0, fromEncrypt.Length);
Console.WriteLine($"Dados descriptografados: {/.GetString(fromEncrypt)}");