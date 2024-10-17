
//XHandler xHandler = new XHandler(() => Test());
//XHandler xHandler2 = Test;
//xHandler2.Invoke();
//xHandler();

//void Test()
//{
//    Console.WriteLine("Test");
//}

//YHandler yHandler = new YHandler((a, p) => TestY(a, p));

//(int, char) TestY(A a, (string, int) p)
//{
//    return (a.IntProperty, p.Item1.First());
//}


//public delegate void XHandler();

//public delegate (int, char) YHandler(A a, (string, int) p);


//public delegate void XHandler3();

//public class A
//{
//    public int IntProperty { get; set; }
//}






//multicast delegate

XHandler xDelegate = () => Console.WriteLine("Test1");
xDelegate += () => Console.WriteLine("Test2");
xDelegate += () => Console.WriteLine("Test3");
xDelegate += () => Console.WriteLine("Test4");
xDelegate.Invoke();

public delegate void XHandler();
