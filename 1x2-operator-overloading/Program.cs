




Student student = new Student { Name = "John", Age = 25 };
Book book = new Book { Title = "C# Advanced", Author = "John Doe" };

var result = student + book;

//var result2 = book + student; // Error


Server.Download(5);
Server.Upload(5);

Server server1 = new Server();
bool result3 = server1 >> 5;
bool result4 = server1 << 5;


Math math = new Math();
math++;
math++;
Console.WriteLine(math.Count); // 2


Database _database = new Database();
bool connectionState = _database + DatabaseType.SQLServer;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public List<Book> Books { get; set; }



}
class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public static Student operator +(Student student, Book book)
    {
        student.Books.Add(book);
        return student;
    }
}
class Server
{
    public static void Download(int fileCount)
    {
        for (int i = 0; i < fileCount; i++)
        {
            Console.WriteLine("Downloading file " + i);
        }
    }
    public static void Upload(int fileCount)
    {
        for (int i = 0; i < fileCount; i++)
        {
            Console.WriteLine("Uploading file " + i);
        }
    }
    public static bool operator >>(Server server, int fileCount)
    {
        Upload(fileCount);
        return true;
    }
    public static bool operator <<(Server server, int fileCount)
    {
        Download(fileCount);
        return true;
    }
}
public class Math
{
    public int Count { get; set; } = 0;



    //++ veya -- operatörlerini aşırı yükleyebiliriz. İşleme tabi tutulurken tekil bir parametre alır.
    //Bu tekil parametrede overloadingin yapıldığı sınıfın türünden olmak zorundadır.
    //Ve yine ++ , -- operatörlerinin aşırı yüklenmesi durumunda geriye döndürülen değer yine aynı sınıf türünden olmalıdır.
    public static Math operator ++(Math math)
    {
        ++math.Count;
        return math;
    }
    public static Math operator --(Math math)
    {
        ++math.Count;
        return math;
    }
}

public class Database
{
    static string _connectionString;
    public static bool operator +(Database database, DatabaseType databaseType)
    {
        _connectionString = databaseType switch
        {
            DatabaseType.SQLServer => "SQL Server Connection String",
            DatabaseType.Oracle => "Oracle Connection String",
            _ => throw new NotImplementedException()
        };
        //Open Connection
        return true;
    }
}
public enum DatabaseType
{
    SQLServer,
    Oracle
}