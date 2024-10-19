


class MyObservable : IObservable<int>
{
    List<IObserver<int>> _observers = new List<IObserver<int>>();

    public IDisposable Subscribe(IObserver<int> observer)
    {
        if (!_observers.Contains(observer))
            _observers.Add(observer);

        return new Unsubscriber(() =>
        {
            _observers.Remove(observer);
            observer.OnCompleted();

        });
    }
    public void Notify(int value)
        => _observers.ForEach(observer => observer.OnNext(value));

}

class Unsubscriber(Action unSubscription) : IDisposable
{

    public void Dispose()
    {
        unSubscription?.Invoke();
        unSubscription = null;
    }
}

class MyObserver : IObserver<int>
{
    public void OnCompleted()
    {
        Console.WriteLine("Completed");
    }

    public void OnError(Exception error)
    {
        Console.WriteLine("Error");
    }

    public void OnNext(int value)
    {
        Console.WriteLine(value);
    }
}

class Program
{
    static void Main(string[] args)
    {
        var observable = new MyObservable();
        var observer = new MyObserver();

        var subscription = observable.Subscribe(observer);

        observable.Notify(1);
        observable.Notify(2);
        observable.Notify(3);

        subscription.Dispose();

        observable.Notify(4);
        observable.Notify(5);
        observable.Notify(6);

        Console.ReadKey();
    }
}