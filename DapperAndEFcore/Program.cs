// See https://aka.ms/new-console-template for more information
using DapperAndEFcore.Service.DapperFolder;
using DapperAndEFcore.Service.EFcore;

Console.WriteLine("Hello, World!");
#region database
//var clservice = new ClientService();
/*clservice.Add(new Client()
{
    Id = 3,
    FirstName = "Vali",
    LastName = "Aliyev",
    Address = "Chorsu"
});*/
/*clservice.Update(new Client()
{
    Id = 1,
    FirstName = "Update",
    LastName = "Updatov",
    Address = "Yangi"
});*/
/*var clientlist =clservice.GetAllClients();
foreach(var client in clientlist)
{
    Console.WriteLine($"{client.Id} {client.FirstName} {client.LastName} {client.Address}");
}*/

var db = new ClientServiceDapper();
/*db.AddClient(new Client
{
    Id = 53,
    FirstName = "Dapper",
    LastName = "Yangi Dapper",
    Address = "dapper",
});*/

/*db.Update(new Client
{
    Id = 53,
    FirstName = "newdapper",
    LastName = "new Dapper",
    Address = "update",
});*/
//db.DeleteClient(53);
/*var client = db.GetById(1);
Console.WriteLine($"{client.Id} {client.FirstName} {client.LastName} {client.Address}");
*/
#endregion data

//int firstname = "nimadir";
/*int number = 1;
var num = 34;
var name = "Kimdir";
dynamic raqam = 10;
dynamic ism = "ishlash";
object son = 13;
object lastname = "job";*/


int raqamlar=12;
MyMethod(ref raqamlar);

void MyMethod(ref int son)
{
    Console.WriteLine("Hello");
}