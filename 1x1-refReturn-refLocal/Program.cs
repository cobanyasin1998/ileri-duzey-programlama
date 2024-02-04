
//Ref keyword ne işe yarar?
//Ref keyword, bir metoda bir değişkenin referansını göndermek için kullanılır.


using System.Security.Cryptography.X509Certificates;

int b = 5;
X(ref b);
Console.WriteLine(b); // 10
void X(ref int a)
{
    a = 10;
}
//Ref Return keyword ne işe yarar?
//Ref Return keyword, bir metottan bir değişkenin referansını döndürmek için kullanılır.

int ab = 5;
ref int _ab = ref XY(ref ab);

Console.WriteLine(ab); // 10

ref int XY(ref int ab)
{
    ab = 10;
    return ref ab;
}

//Ref return - Kritik 1

int _a = 4;
var __a = A(ref _a);

Console.WriteLine(_a); // 10

ref int A(ref int _a)
{
    _a = 10;
    return ref _a;
}

//Ref return - Kritik 2

int _b = 4;
var __b = B(ref _b);
Console.WriteLine(_b);

ref int B(ref int _b)//parametreden farklı bir değişkenin referansını döndürdüğümüzde hata alırız.
{
    int _c = 10;
    _b = 10;
    // return ref _c; // _c'nin referansını döndürdüğü için hata alırız.
    return ref _b;
}

//Örnek 

int[] numbers = { 1, 2, 3, 4, 5 };

ref int numberRef = ref FindElement(numbers, 3);

ref int FindElement(int[] array, int target)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == target)
        {
            return ref array[i];
        }
    }
    throw new IndexOutOfRangeException($"{nameof(target)} not found");

}

//Ref Local keyword ne işe yarar?
//Ref Local keyword, bir değişkenin referansını tutmak için kullanılır.

char _o = 'o';
ref char p = ref _o;