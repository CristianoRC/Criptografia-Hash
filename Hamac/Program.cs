using System.Security.Cryptography;
using System.Text;

Console.Write("Digite a entrada: ");
var text = Console.ReadLine();
Console.Write("Digite a senha: ");
var password = Console.ReadLine();

var hmacSha256 =  new HMACSHA256(Encoding.UTF8.GetBytes(password));
var hmac = hmacSha256.ComputeHash(Encoding.UTF8.GetBytes(text));

string stringByteHmac = BitConverter.ToString(hmac).Replace("-", string.Empty);
Console.WriteLine(stringByteHmac);