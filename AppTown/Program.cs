// See https://aka.ms/new-console-template for more information

using Town;
List<Villagers> village = new List<Villagers>()
{
    new Peasant("humpbacked", "David", "Fisher", new DateTime(1844, 1, 9), 100, true),
    new Peasant("conky", "Ernest", "Fisher", new DateTime(1847, 5, 1), 45, false),
    new Officer("greedy1", "Albedo", "Herrum", new DateTime(1825, 10, 1), 45, false),
};
void Command(int i)
{
    switch (i)
    {
        case (0):
            CreateVillage();
            Main();
            break;
        case (1):
            ManageResident();
            Main();
            break;
        case (2):
            return;
    }
};

void ManageResident()
{
    int number = 0;
    Console.WriteLine("set your villagers (number):\n");
    foreach (var variable  in  village)
    {
        Console.Write(number++ + "----");
        
        Console.Write(variable.BioInformation());
    };
    number  =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("this villager has the following features:");
    switch (village[number].ToString())
    {
        case("Town.Peasant"):
            PeasantAction((Peasant)village[number]);
            break;
        case("Town.Officer"):
            OfficerAction((Officer)village[number]);
            break;

        default:
            return;
    }
}

void OfficerAction(Officer village)
{
    Console.WriteLine("Officer action: \n 1) enjoy");
    int i = Convert.ToInt32(Console.ReadLine());
    switch (i)
    {
        case  1:
            Console.Write(village.Enjoy());
            break;
        default:
            return;
    }
}

void PeasantAction( Peasant village)
{
    Console.WriteLine("Peason action: \n 1) plow");
    int i = Convert.ToInt32(Console.ReadLine());
    switch (i)
    {
      case  1:
          Console.Write(village.Plow());
          break;
      default:
          return;
    }
}


void CreateVillage()
{
    Console.WriteLine("Set his/her nickname \n");
    string? nickname = Console.ReadLine();
    Console.WriteLine("Set his/her first Name \n");
    string? first_Name = Console.ReadLine();
    Console.WriteLine("Set his/her second Name \n");
    string? second_Name = Console.ReadLine();
    Console.WriteLine("Set his/her date birthdays \n");
    DateTime  birthdays =Convert.ToDateTime(Console.ReadLine());
    Console.WriteLine("Set his/her balance \n");
    int balance = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Set his/her sex 0- male, 1=woman \n");
    int sex_i =Convert.ToInt32(Console.ReadLine());
    bool sex;
    switch (sex_i)
    {
        case 0:
            sex = true;
            break;
        case 1: 
            sex = false;
            break;
        default:
            sex = false;
            break;
    }
    Console.WriteLine("Set his/her job \n 1 - Peasant, 2 - Officer");
    int job = Convert.ToInt32(Console.ReadLine());
    switch (job)
    {
        case 1:
            village.Add(new Peasant( nickname,  first_Name,  second_Name,  birthdays,  balance,  sex));
            Console.WriteLine("You successfully add new Peasant" + village[village.Count-1].Informer());
            Main();
            break;
        case 2: 
            village.Add(new Officer( nickname,  first_Name,  second_Name,  birthdays,  balance,  sex));
            Console.WriteLine("You successfully add new Officer" + village[village.Count-1].Informer());
            Main();
            break;
    }
    
};
bool first_login = false;
void Main()
{
    
    if (!first_login)
    {
            Console.Write("Hello, my King \n now in your town "+village.Count+" village :\n ");
            Thread.Sleep(2000);
            foreach (var villagers in village)
            {
                Console.Write(villagers.Informer());
            };
            first_login = true;
            Thread.Sleep(2000);
    }

    Console.WriteLine("what are you going to do? \n 0 - create new village \t 1 - manage residents \t  out of program");
    int move = Convert.ToInt32(Console.ReadLine());
    
    Command(move);
}

Main();

