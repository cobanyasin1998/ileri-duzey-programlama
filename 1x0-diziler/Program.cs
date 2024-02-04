

//Dizilerde Derinlemesine İnceleme

//Tek boyutlu dizi tanımlama
int[] array = new int[10];

//Çok boyutlu dizi tanımlama
int[,,] arrays = new int[3, 3, 3]
{
    {
        {1, 2, 3},
        {4, 5, 6},
        {7, 8, 9}
    },
    {
        {1, 2, 3},
        {4, 5, 6},
        {7, 8, 9}
    },
    {
        {1, 2, 3},
        {4, 5, 6},
        {7, 8, 9}
     }
};

//Matris tanımlama
int[,] matrix = new int[3, 3]
{
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};

//Düzensiz Diziler (Jagged Arrays) tanımlama
int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[2] { 1, 2 };
jaggedArray[1] = new int[3] { 1, 2, 3 };
jaggedArray[2] = new int[4] { 1, 2, 3, 4 };


//Createinstance metodu ile dizi oluşturma

int[] d1 = (int[])Array.CreateInstance(typeof(int), 2);
int[,,] d2 = (int[,,])Array.CreateInstance(typeof(int), 2, 2,2);


//Dizilerde Yeni Syntax Kullanımı

(int a,string b)[] tupleArray = new (int a, string b)[] 
{ 
    (1, "bir"), 
    (2, "iki"), 
    (3, "üç") 
};