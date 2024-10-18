
//int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//List<string> list = new List<string>() {  };
//list.Add("Hello");
//list.Add("World");
//list.Add("!");

using System.Collections;

MyClass myClass = new MyClass()
{
7547,754745754
};

myClass.Add(1);
myClass.Add(2);

class MyClass :IEnumerable<int>
{
    List<int> list = new List<int>();
    public int Id { get; set; }
    public string Name { get; set; }

    public IEnumerator<int> GetEnumerator() 
        => list.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() 
        => list.GetEnumerator();

    public void Add(int item) 
        => list.Add(item);
}