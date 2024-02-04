

while (true)
{
    var key = Console.ReadKey();
    if (key.Key == ConsoleKey.R)
    {
        throw new CustomException();
    }
}

class CustomException : Exception
{

    public CustomException(string message) : base(message)
    {
    }
    public CustomException() : base("HATA")
    {

    }

}
