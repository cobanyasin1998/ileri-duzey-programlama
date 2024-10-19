var list = new List<BaseClass>
{
    new BaseClass { IsActive = true },
    new BaseClass { IsActive = false },
    new BaseClass { IsActive = true },
    new BaseClass { IsActive = false },
    new BaseClass { IsActive = true }
};
var query = list.AsQueryable().GetActive();

foreach (var item in query)
{
    Console.WriteLine(item.IsActive);
}
static class ExtensionMethods
{
    public static IQueryable<T> GetActive<T>(this IQueryable<T> baseClass, bool isActive = true) where T : BaseClass
    {
        return baseClass.Where(x => x.IsActive == isActive);
    }
}





class BaseClass
{
    public bool IsActive { get; set; }
}