namespace Bcrypt;

class Program
{
    static void Main()
    {
        Console.Write("Digite a senha: ");
        var password = Console.ReadLine();
        
        var hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
        Console.WriteLine($"Hash gerado: {hashedPassword}");

        Console.WriteLine("Digite a senha novamente para verificar: ");
        var passwordToVerify = Console.ReadLine();

        var isValid = BCrypt.Net.BCrypt.Verify(passwordToVerify, hashedPassword);
        Console.WriteLine($"A senha está {(isValid ? "correta" : "incorreta")}!");
    }
}