using TBCustomLinq;
using System.Linq;
using TBCustomLinq.Context;
using Microsoft.Extensions.Logging;

var loggerFactory = LoggerFactory.Create(builder =>
{
    builder
    .AddFilter("Microsoft.EntityFrameworkCore.Model.Validation", LogLevel.Error)
    .AddFilter("Microsoft.EntityFrameworkCore.Infrastructure", LogLevel.Error)
    .AddConsole();
});

var dbContext = new TBDbContext(loggerFactory);

var gmailUsers = dbContext.Users
                            .Where(i => i.EmailAddress.EndsWith("gmail.com") && i.Id % 2 == 0)
                            .Where(i => i.Id % 2 == 0)
                            .ToList();

Console.WriteLine("\n\n\nGmailusers count: {0}", gmailUsers.Count);


//var users = new List<UserModel>()
//{
//    new UserModel(){ Id = 8,FirstName = "Salih", LastName = "Cantekin", EmailAddress = "salihcantekin@gmail.com" },
//    new UserModel(){ Id = 2,FirstName = "Salih2", LastName = "Cantekin" },
//    new UserModel(){ Id = 3,FirstName = "Salih3", LastName = "Cantekin" },
//    new UserModel(){ Id = 4,FirstName = "Salih4", LastName = "Cantekin" }
//};

//var linqUser = users
//                .Where(i => i.Id % 2 == 0 && i.Id > 5)
//                .Where(i => i.EmailAddress.EndsWith("gmailaklsdjlaksd.com"))
//                .Where(i => i.Id > 5)
//                .ToList();


//var tbLinqUser = users
//                    .TBWhere_EvenId()
//                    .TBWhere_GmailUsers()
//                    .TBToList();


//var evenIdUsers = users.TBToList().TBWhere_EvenId().TBFirstOrDefault();

//var firstUser = users.TBFirstOrDefault();
//Console.WriteLine("First user name: {0}", evenIdUsers.FirstName);

//Console.WriteLine("evenIdUsers Count: {0}", evenIdUsers.Count());

// var salihUser = users.Where(x => x.FirstName == "Salih").Select(x => x.FirstName).ToList();

Console.ReadLine();
