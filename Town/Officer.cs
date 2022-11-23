namespace Town;

public class Officer: Town.Villagers
{
    public Officer(string nickname, string firstName, string secondName, DateTime birthdays, int balance, bool sex):base(nickname,  firstName,  secondName,  birthdays,  balance,  sex)
    {
        
    }
    public void enjoy()
    {
        Console.WriteLine("listen to the groans of the inhabitants");
        this.Helth = this.Helth+10;
    }
    
}