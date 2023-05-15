//// See https://aka.ms/new-console-template for more information

//using WizardsandWarriors.Models;

//var party = new List<Player>();

//Player player1 = new Warrior();
//Player player2 = new Wizard();

////ceci ne devrait pas marcher!!!
//player1.EquippedWeapon = new Staff();
//player2.EquippedWeapon = new Sword();

//party.Add(player1);
//party.Add(player2);

//Func<Player> wizardFactory = () =>
//{
//    var result = new Wizard();
//    var staff = new Staff();
//    result.EquippedWeapon = staff;
//    return result;
//};

//Func<Player> warriorFactory = () =>
//{
//    var result = new Warrior();
//    var sword = new Sword();
//    result.EquippedWeapon = sword;
//    return result;
//};

//for(var i = 0; i < 10; i++)
//{
//    var factory = Random.Shared.Next()%2 == 0 ? warriorFactory : wizardFactory;
//    party.Add(factory());
//}

//Console.WriteLine($"may party contains {party.OfType<Warrior>().Count()} warriors");

//var i = 1;

//Action incrementCommand = () => i++;
//Action multiplyCommand = () => i *= 2;

//Action action1;
//Action action2;

//if (Random.Shared.Next() % 2 == 0)
//{
//    action1 = incrementCommand;
//    action2 = multiplyCommand;
//}
//else
//{
//    action2 = incrementCommand;
//    action1 = multiplyCommand;
//}

//while (true)
//{
//    Console.WriteLine($"current state: {i}");
//    var playerInstruction = Console.ReadLine();

//    switch (playerInstruction)
//    {
//        case "1":
//            action1();
//            break;
//        case "2":
//            action2();
//            break;
//        default:
//            Console.WriteLine("please type '1' or '2'");
//            break;
//    }
//}

using WizardsandWarriors;
using WizardsandWarriors.Services;

//Singleton GetSingleton1()
//{
//    return Singleton.Instance;
//}

//Singleton GetSingleton2()
//{
//    return (Singleton)Activator.CreateInstance(typeof(Singleton), true);
//}



















//Singleton singleton1 = GetSingleton1();
//Singleton singleton2 = GetSingleton2();

//Console.WriteLine(singleton1 == singleton2);











IServiceLocator serviceLocator = new ServiceLocator();

//someplace in the program
serviceLocator.Register<IHelloWorldService, HelloWorldService>();

//somewhere else
var helloWorldService = serviceLocator.GetService<IHelloWorldService>();
helloWorldService.Hello();