namespace JDB.Playground.Dotnet.Nuget.TestClassLib
{
    public class MyTest
    {
        public string SayHello(string name = "World")
        {
            return $"Hello {name}!";
        }
    }
}
