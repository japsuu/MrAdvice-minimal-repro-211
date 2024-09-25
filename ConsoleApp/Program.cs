using ClassLibrary1;

namespace Test1;

internal static class Program
{
    private static void Main(string[] args)
    {
        MethodWithAttribute();
    }
    
    
    [Example]
    private static void MethodWithAttribute()
    {
        Console.WriteLine("test");
    }
}