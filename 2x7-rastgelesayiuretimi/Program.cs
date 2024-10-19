

using System.Security.Cryptography;

Random random = new Random(100);//seed value verilirse her zaman aynı değerler üretir

for (int i = 0; i < 15; i++)
{
    Console.WriteLine(random.Next());
}


Random random2 = new Random(DateTime.UtcNow.Microsecond);// her seferinde farklı değerler üretir
for (int i = 0; i < 15; i++)
{
    Console.WriteLine(random2.Next());
}

using var rng =  RandomNumberGenerator.Create();
byte[] data = new byte[10];
rng.GetBytes(data);
int randomNumber = BitConverter.ToInt32(data, 0);
Console.WriteLine(randomNumber);