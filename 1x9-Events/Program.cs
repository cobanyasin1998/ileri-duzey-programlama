//MyEventPublisher publisher = new MyEventPublisher();
//MyEventPublisher.XHandler xHandler = new MyEventPublisher.XHandler(X);
//publisher.MyEvent += () =>
//{
//    X();
//};

//publisher.RaiseEvent();

//void X()
//{
//    Console.WriteLine("Event Tetiklendi");
//}

//class MyEventPublisher
//{
//    public delegate void XHandler();
//    XHandler xdelegate;
//    public event XHandler MyEvent
//    {
//        add
//        {
//            Console.WriteLine("Event Added");
//            xdelegate += value;
//        }
//        remove
//        {
//            Console.WriteLine("Event Removed");
//            xdelegate -= value;
//        }

//    }
//    public void RaiseEvent()
//    {
//        xdelegate?.Invoke();

//    }
//}


string path = @"C:\Users\Yasin\Desktop\x";

PathControl pathControl = new PathControl();
pathControl.PathControlEvent += (long sizeMb) => Console.WriteLine("Boyut 50 MB aştı: Size Mb "+ sizeMb.ToString());

await pathControl.Control(path);
class PathControl
{
    public delegate void PathHandler(long sizeMB);
    public event PathHandler PathControlEvent;
    public async Task Control(string path)
    {
        while (true)
        {
            await Task.Delay(1000);
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            var files = directoryInfo.GetFiles();

            var size =await Task.Run(() => directoryInfo.EnumerateFiles("*", SearchOption.AllDirectories).Sum(file => file.Length));

            var sizeMB = size / 1024 / 1024;
            if (sizeMB > 0) {
                PathControlEvent?.Invoke(sizeMB);
            }

        }
    }

}