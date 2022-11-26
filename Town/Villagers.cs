namespace Town;

public abstract class Villagers
{
    private string _firstName; 
    private string _secondName;
    private string _nickname;
    private DateTime _birthdays;
    protected int Balance;
    private bool _sex;
    protected int Health;
    public Villagers(string nickname, string firstName, string secondName, DateTime birthdays, int balance, bool sex)
    {
        this._nickname = nickname;
        _firstName = firstName;
        _secondName = secondName;
        this._birthdays = birthdays;
        this.Balance = balance;
        this._sex = sex;
        this.Health = 100;
    }
    
    public string Informer()
    {

        return (_nickname +" "+
        _firstName+ " "+_secondName+ " \n"+"job title: "+ ToString()+ "\n"+(Balance + " - his|her balance \n")+
        _birthdays + " - date birthdays \n"+ (_sex ? "sex - man\n" : "sex - woman\n")+Health+"Health now") ;
    }
    public string BioInformation()
    {
        return _nickname + _firstName + _secondName + "\n";
    }
    
}