//Covariance ve Contravariance terimleri; array types, delegate types, return types ve generic types için örtülü
//implicit referans dönüşümlerini ifade eder. 

//Covariance: Covariance, matematikte iki değişkenin birlikte değişmesi anlamına gelir.
//İki değişkenin birlikte aynı yöne doğru değişmesine denir Yani birisi artıyorsa diğeri de artar. !! Poliformizde geçerli değildir. !! Bu atama uyumluluğu demektir.
//Contravariance: Contravariance, matematikte iki değişkenin birlikte değişmesi anlamına gelir. İki değişkenin birlikte zıt yöne doğru değişmesine denir. Yani birisi artıyorsa diğeri azalır.
#region Giriş
{
    //int i = 3;
    //string s = "asd";
    //char c ='c';

    //Polimorfizm
    A a = new B();

    //Covariance
    object[] isimler = new string[5] { "Yasin", "Yasin", "Yasin", "Yasin", "Yasin" };
    A[] aDizisi = new B[5];
    IEnumerable<object> arabalar = new List<string>() { "Opel" };
    IEnumerable<A> aArabalar = new List<B>() { new B() };
    Func<A> func = GetB;
    B GetB() => new B();

    //Contravariance
    Action<B> action = DoSomething;
    void DoSomething(A a) { }
}
#endregion

#region Covariance
{
    //Spesifik bir türün genel bir türün referansına atanabilmesi durumudur.
    #region ArrayTypes
    {
        
        object[] objects = new string[5] { "Yasin", "Yasin", "Yasin", "Yasin", "Yasin" };
        objects[0] = "Yasin";
        objects[1] = true; //Tehlikeli
    }
    #endregion
    #region Delegate Types

    #endregion
    #region Generic Types
    {
        IAnimal<object> animal = new Animal<string>();

    }
    #endregion
    #region Return Types
    {

    }
    #endregion
}

#endregion

class A
{
    public virtual A X()=> new A();
}
class B : A
{
    public override B X()
    {
        return new();
    }
}
interface IAnimal<out T> { }
class Animal<T> : IAnimal<T> { }