
// Implicit(Kapalı) and Explicit(Açık) operators

A a1 = new B();
A a2 = (A)new B();

B b = (B)new A();
class A
{
    public int Name { get; set; }
    public static implicit operator A(B b)
    {
        return new A()
        {
            Name = b.Title
        };
    }
}

class B
{
    public int Title { get; set; }
    public static explicit operator B(A a)
    {
        return new B()
        {
            Title = a.Name
        };
    }
}