

#region Activator Sınıfı ile Nesne Oluşturma
using System.Dynamic;

{
    Type objectType = Type.GetType("MyClass");

    MyClass instance = (MyClass)Activator.CreateInstance(objectType);
}
#endregion

#region DynamicObject Sınıfı ile Nesne Üretme
{
    dynamic product = new Product();
    product.Oylesine = 1;
    product.TrySetMember("Name", "Laptop");
    product.TrySetMember("Price", 5000);
    Console.WriteLine(product.Name);
    Console.WriteLine(product.Price);
    Console.WriteLine(product.Oylesine);

}
#endregion

#region dynamic keyword'ü ile Nesne Üretme
{
    dynamic product = new ExpandoObject();
    product.Name = "Laptop";
    product.Price = 5000;
    Console.WriteLine(product.Name);
    Console.WriteLine(product.Price);
}
#endregion

public class MyClass
{
    public MyClass()
    {
        Console.WriteLine($"{nameof(MyClass)} instance created");
    }
    public int MyProperty { get; set; } = 5;
}

public class Product : DynamicObject
{
    public Product()
    {
        Console.WriteLine($"{nameof(Product)} instance created");
    }
    private readonly Dictionary<string, object> properties = new();
    public override bool TrySetMember(SetMemberBinder binder, object? value)
    {
        properties.Add(binder.Name, value);
        return true;
    }
    public override bool TryGetMember(GetMemberBinder binder, out object? result)
    {

        return properties.TryGetValue(binder.Name, out result);
    }
}