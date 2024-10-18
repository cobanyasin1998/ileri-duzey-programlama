
using System.Reflection;
using System.Reflection.Emit;

Assembly assembly = Assembly.GetExecutingAssembly();
var types = assembly.GetTypes();

Console.WriteLine();

Personel personel = new Personel();
personel.Name = "John";
personel.Surname = "Doe";
personel.Age = 30;

var type1 = personel.GetType();
var type2 = typeof(Personel);

type1.GetProperties().ToList().ForEach(p => Console.WriteLine(p.Name));
type1.GetFields().ToList().ForEach(p => Console.WriteLine(p.Name));


DynamicMethod dynamicMethod = new DynamicMethod(
    "Toplama",
    typeof(int),
    new Type[] {
        typeof(int), typeof(int)
    },
    m:typeof(Program).Module
    );

ILGenerator ilGenerator = dynamicMethod.GetILGenerator();
ilGenerator.Emit(OpCodes.Ldarg_0);
ilGenerator.Emit(OpCodes.Ldarg_1);
ilGenerator.Emit(OpCodes.Add);
ilGenerator.Emit(OpCodes.Ret);

dynamicMethod.CreateDelegate(typeof(Func<int, int, int>));

var result = dynamicMethod.Invoke(null, new object[] { 10, 20 });
Console.WriteLine(result);

var myClass = new MyClass();
var myClassType = typeof(MyClass);
var members = myClassType.GetMembers(BindingFlags.NonPublic | BindingFlags.Instance);
members.ToList().ForEach(m => Console.WriteLine(m.Name));


class MyClass
{
    private int myField;
    public int myProperty;
    public void MyMethod()
    {
        Console.WriteLine("Hello World!");
    }
}

class Personel
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
}