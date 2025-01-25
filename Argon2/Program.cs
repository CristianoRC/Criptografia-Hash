using System.Text;
using System.Security.Cryptography;
using Konscious.Security.Cryptography;

namespace Argon2;

class Program
{
    // Parâmetros do Argon2
    private const int SaltSize = 16; // Tamanho do salt em bytes (128 bits)
    private const int HashSize = 32; // Tamanho do hash em bytes (256 bits)
    private const int DegreeOfParallelism = 4; // Número de threads
    private const int NumberOfIterations = 20; // Número de iterações (10 - mínimo recomendado)
    private const int MemorySize = 256 * 1024; // Tamanho da memória em KB (64MB - mínimo recomendado)

    static void Main()
    {
        Console.Write("Digite a senha: ");
        var password = Console.ReadLine();

        var salt = new byte[SaltSize];
        RandomNumberGenerator.Fill(salt);

        var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password!))
        {
            Salt = salt,
            DegreeOfParallelism = DegreeOfParallelism,
            Iterations = NumberOfIterations,
            MemorySize = MemorySize
        };
        
        var hash = argon2.GetBytes(HashSize);
        Console.WriteLine($"Hash gerado: {Convert.ToHexString(hash)}");
        Console.WriteLine($"Salt usado: {Convert.ToHexString(salt)}");

        Console.Write("Digite a senha novamente para verificar: ");
        var passwordToVerify = Console.ReadLine();

        var argon2Verify = new Argon2id(Encoding.UTF8.GetBytes(passwordToVerify!))
        {
            Salt = salt,
            DegreeOfParallelism = DegreeOfParallelism,
            Iterations = NumberOfIterations,
            MemorySize = MemorySize
        };

        var hashToVerify = argon2Verify.GetBytes(HashSize);
        var isValid = hash.SequenceEqual(hashToVerify);

        Console.WriteLine($"A senha está {(isValid ? "correta" : "incorreta")}!");
    }
}