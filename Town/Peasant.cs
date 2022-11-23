namespace Town;

public class Peasant : Town.Villagers
{
    public Peasant(string nickname, string firstName, string secondName, DateTime birthdays, int balance, bool sex):base( nickname,  firstName,  secondName,  birthdays,  balance,  sex)
    {
        
    }
    public void plow()
    {
        Console.WriteLine("Negroes plow, Negroes plow this is our share");
        this.Helth = this.Helth-1;
        this.balance = this.balance + 10;
    }
}