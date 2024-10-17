#region Action
{
    Action action = () => { Console.WriteLine("Boş Action"); };
    Action<int> action2 = (int i) => { Console.WriteLine("Bir parametreli action " + i); };
    Action<int, int> action3 = (int i, int j) => { Console.WriteLine("Çoklu parametreli action " + i + " " + j); };
}
#endregion
#region Func
{
    Func<int> func = () => { return 5; };
    Func<int, int> func2 = (int i) => { return i; };
    Func<int, int, int> func3 = (int i, int j) => { return i + j; };
}
#endregion
#region Predicate
{
    Predicate<int> predicate = (int i) => { return i > 5; };
}
#endregion
#region Lambda Discard Parameters
{
    Func<int, int, int> func = (int _, int j) => { return j; };
}
#endregion