namespace Town;

public class Peasant : Villagers
{
    public Peasant(string nickname, string firstName, string secondName, DateTime birthdays, int balance, bool sex):base( nickname,  firstName,  secondName,  birthdays,  balance,  sex)
    {
        
    }
    public string Plow()
    {
        Health--;
        Balance = Balance + 10;
        return "Negroes plow, Negroes plow this is our share";
    }
}