using System.Security.Cryptography;


var data = new byte[1024];
Random.Shared.NextBytes(data);

var hash1 = SHA512.HashData(data);
var hash2 = CryptographicOperations.HashData(HashAlgorithmName.SHA512, data);

Console.WriteLine(Convert.ToBase64String(hash1));
Console.WriteLine(Convert.ToBase64String(hash2));
Console.ReadKey();