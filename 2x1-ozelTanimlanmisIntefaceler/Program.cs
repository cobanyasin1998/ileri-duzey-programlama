#region IComparer
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data.SqlClient;

{
    Person person1 = new Person { Name = "Yasin", Age = 25 };
    Person person2 = new Person { Name = "Meltem", Age = 30 };
    Person person3 = new Person { Name = "Elif", Age = 35 };


    List<Person> peoples = new List<Person> { person1, person2, person3 };

    peoples.Sort(new AgeComparer());

    foreach (var people in peoples)
    {
        Console.WriteLine(people.Name);
    }

}


#endregion
#region IComparable Interface
{
    Person person1 = new Person { Name = "Yasin", Age = 25 };
    Person person2 = new Person { Name = "Meltem", Age = 30 };

    Console.WriteLine(person1.CompareTo(person2));
}
#endregion
#region ICloneable Interface
{
    Person person1 = new Person { Name = "Yasin", Age = 25 };
    Person person2 = (Person)person1.Clone();
}
#endregion

#region INotifyPropertyChanged Interface
{
    Person p = new Person() { IdentityNumber = "123456789" };
    p.PropertyChanged += (sender, args) =>
    {
        Console.WriteLine("Property Changed: " + args.PropertyName);
    };

    p.IdentityNumber = "987654321";
    Console.WriteLine(p.IdentityNumber);

}
#endregion

#region IEquatable Interface
{
    Person person1 = new Person { Name = "Yasin", Age = 25 };
    Person person2 = new Person { Name = "Meltem", Age = 30 };

    Console.WriteLine(person1.Equals(person2));
}
#endregion

#region IEnumerable Interface
{
    Depo depo = new Depo();


    foreach (var item in depo)
    {
        Console.WriteLine(item);
    }
    var urunler2 = depo.Where(y => y.StartsWith("a")).ToList();
}
#endregion

#region IDisposable

using MyDatabase myDatabase = new MyDatabase();


class MyDatabase : IDisposable
{
    SqlConnection connection;
    SqlCommand SqlCommand;
    public MyDatabase()
    {
        connection = new SqlConnection("connection string");
        connection.Open();
        SqlCommand = new SqlCommand("Select * from Table", connection);
    }

    public void Dispose()
    {
        connection.Close();
    }
    ~MyDatabase()
    {
        connection.Close();
    }
}

#endregion

class Person : IComparable<Person>, ICloneable, INotifyPropertyChanged, IEquatable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string identityNumber { get; set; }
    public string IdentityNumber
    {
        get
        {
            return identityNumber;
        }
        set
        {
            identityNumber = value;
            PropertyChanged?.Invoke(this, new(nameof(IdentityNumber)));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public object Clone()
    {
        return this.MemberwiseClone();
    }

    public int CompareTo(Person? other)
    {
        return this.Age.CompareTo(other.Age);
    }

    public bool Equals(Person? other)
    {
        return this.Name == other.Name && this.Age == other.Age;
    }
}

class AgeComparer : IComparer<Person>
{
    public int Compare(Person? x, Person? y)
    {
        return x.Age.CompareTo(y.Age);
    }
}

class Depo : IEnumerable<string>
{
    List<string> _urunler = new List<string> { "Bilgisayar", "Telefon", "Klavye" };
    public IEnumerator GetEnumerator()
    {

        return _urunler.GetEnumerator();
    }

    IEnumerator<string> IEnumerable<string>.GetEnumerator()
    {
        return _urunler.GetEnumerator();
    }
}
