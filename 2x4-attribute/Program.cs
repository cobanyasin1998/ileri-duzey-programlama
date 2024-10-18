

using System.Reflection;
using System.Text.Json.Serialization;

Assembly assembly = Assembly.GetExecutingAssembly();
assembly.GetTypes()
    .Where(t => t.GetCustomAttribute<MyAttribute>() is not null)
    .ToList()
    .ForEach(t => Console.WriteLine(t.Name));


[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
class MyAttribute : Attribute
{
    public MyAttribute(Type type) { }
}
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
class ClassAttribute : Attribute
{
    public ClassAttribute(Type type) { }
}


[JsonSerializable(typeof(MyClass))]
[MyAttribute(typeof(MyClass))]
[ClassAttribute(typeof(MyClass))]
class MyClass
{
    [MyAttribute(typeof(MyClass))]
    public void MyMethod()
    {
        Console.WriteLine("Hello World!");
    }
}
