

MyClass<int, string, bool, char> myClass = new MyClass<int, string, bool, char>();
myClass.MyProperty = 5;

UploadFile uploadFile = new UploadFile();
uploadFile.Upload<int>();
uploadFile.X(5);
uploadFile.X<int>(3);

Araba<Ford>.Motor<FordMotoru> b = new();

class MyClass<T1, T2, T3, T4>
{
    public T1 MyProperty { get; set; }
    public T2 MyMethod(T2 value)
    {
        return value;
    }
    public T3 MyProperty1 { get; set; }
    public T4 MyMethod1(T4 value)
    {
        return value;
    }

}

class GenericClass1<T>
{

}

class GenericClass2<T> : GenericClass1<T>
{

}


class UploadFile
{
    public void Upload<T>()
    {
        //
    }
    public void X<T>(T t)
    {
        //
    }
}


class GenericClass<T>  where T:  class, IInterface<T>,new()
{
   
   
    public T MyProperty { get; set; }
    public T MyMethod(T value)
    {
        return value;
    }
}

public interface IInterface<T>
{

}

public class Overloading
{
    public void X(int a)
    {
        //
    }
    public void X(string a)
    {
        //
    }
    public void X<T>(T a)
    {
        //
    }
}

public class  Araba<T1>
{
    public class Motor<T2> where T2: T1
    {

    }
    
}
class Ford
{

}

class FordMotoru : Ford
{

}