using System.Security.Cryptography;
using System.Text;

Console.Write("Digite a entrada: ");
var text = Console.ReadLine();

using var sha256 = SHA256.Create();
var hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(text));

string stringByte = BitConverter.ToString(hash).Replace("-", string.Empty);
Console.WriteLine(stringByte);