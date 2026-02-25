
#region Behavioral Pattern

#region Command

#endregion

#region Iterator
using ConsoleApp1.src.DesignPatterns.Behavioral.Iterator.MyTest;
using System.Runtime.CompilerServices;
ShoppingList shoppingList = new ShoppingList();
shoppingList.Push("Bread");
shoppingList.Push("Milk");
shoppingList.Push("Cola");

var iterator = shoppingList.CreateIterator();

PrintList(shoppingList);
shoppingList.Pop();
PrintList(shoppingList);
void PrintList(ShoppingList shoppingList)
{
    iterator.Reset();
    while (iterator.HasNext())
    {
        Console.WriteLine(iterator.Current());
        iterator.Next();
    }
}
#endregion

#region ChainOfResponsibility
//using ConsoleApp1.src.DesignPatterns.Behavioral.ChainOfResponsibility.MyTest;

//var validator = new Validator();
//var authenticator = new Authenticator();
//var logger = new Logger();

//validator.SetNext(authenticator).SetNext(logger);

//WebServer webServer = new WebServer(validator);
//HTTPRequest request = new HTTPRequest("Leif", "123");
//webServer.Handle(request);

#endregion
#endregion
Console.ReadLine();