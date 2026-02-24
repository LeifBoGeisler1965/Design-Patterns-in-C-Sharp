
#region Behavioral.ChainOfResponsibility
using ConsoleApp1.src.DesignPatterns.Behavioral.ChainOfResponsibility.MyTest;

var validator = new Validator();
var authenticator = new Authenticator();
var logger = new Logger();

validator.SetNext(authenticator).SetNext(logger);

WebServer webServer = new WebServer(validator);
HTTPRequest request = new HTTPRequest("Leif", "123");
webServer.Handle(request);

#endregion
Console.ReadLine();