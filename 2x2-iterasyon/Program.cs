using System.Collections;

Stock stock = new Stock();
StockEnumerator stockEnumerator = new(stock.companies);
foreach (string item in stock)
{
    Console.WriteLine(item);
}

foreach (var name in GetCompanies())
{
    Console.WriteLine(name);
}

IEnumerable GetCompanies()
{
    //return new() { "Microsoft", "Apple", "Google", "Amazon", "Facebook" };
    yield return "Microsoft";
    yield return "Apple";
    yield return "Google";
    yield return "Amazon";
    yield return "Facebook";
    yield break;
}


class Stock : IEnumerable<string>
{
    public List<string> companies = new() { "Microsoft", "Apple", "Google", "Amazon", "Facebook" };

    public IEnumerator<string> GetEnumerator()
    {
        //return companies.GetEnumerator();
        return new StockEnumerator(companies);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        //return companies.GetEnumerator();
        return new StockEnumerator(companies);

    }
}




class StockEnumerator : IEnumerator<string>
{
    private List<string> companies;
    private int index = -1;
    public StockEnumerator(List<string> companies)
    {
        this.companies = companies;
    }
    public string Current
    {
        get
        {
            return companies[index];
        }
    }
    object IEnumerator.Current => companies[index];
    public void Dispose() => companies = null;
    public bool MoveNext()
    {
        index++;
        return index < companies.Count;
    }
    public void Reset()
    {
        index = -1;
    }
}

