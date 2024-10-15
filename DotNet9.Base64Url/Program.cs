using System.Buffers.Text;



var data = new byte[32];
Random.Shared.NextBytes(data);


var base64 = Convert.ToBase64String(data);
_ = Convert.FromBase64String(base64);
Console.WriteLine($"Base64: {base64}");


var url64 = Base64Url.EncodeToString(data);
_ = Base64Url.DecodeFromChars(url64);
Console.WriteLine($" Url64: {url64}");