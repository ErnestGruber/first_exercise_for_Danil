namespace Town;

public class Officer: Villagers
{
    public Officer(string nickname, string firstName, string secondName, DateTime birthdays, int balance, bool sex):base(nickname,  firstName,  secondName,  birthdays,  balance,  sex)
    {
        
    }
    public string Enjoy()
    {
        this.Health = this.Health+10;
        return ("listen to the groans of the inhabitants");
    }
    
}