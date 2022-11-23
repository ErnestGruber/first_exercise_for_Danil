using System.Net.Sockets;
using Microsoft.VisualBasic.CompilerServices;

namespace Town;

public abstract class Villagers
{
    private string first_Name; 
    private string second_Name;
    private string nickname;
    private DateTime birthdays;
    public int balance;
    private bool sex;
    public int Helth;
    public Villagers(string nickname, string firstName, string secondName, DateTime birthdays, int balance, bool sex)
    {
        this.nickname = nickname;
        first_Name = firstName;
        second_Name = secondName;
        this.birthdays = birthdays;
        this.balance = balance;
        this.sex = sex;
        this.Helth = 100;
    }
    
    public void getInfo()
    {
        Console.Write(this.nickname +" ");
        Console.Write(this.first_Name+ " ");
        Console.Write(this.second_Name+ " \n");
        Console.WriteLine("job title: "+ this.ToString());
        Console.WriteLine(this.balance + " - his|her balance");
        Console.WriteLine(this.birthdays + " - date birthdays");
        if (this.sex==true)
        {
            Console.WriteLine("sex - men");
        }else
        {
            Console.WriteLine("sex - woman");
        }
        Console.WriteLine(this.Helth + " - Health now \n");
    }
    public void getBIO()
    {
        Console.Write(this.nickname +" ");
        Console.Write(this.first_Name+ " ");
        Console.Write(this.second_Name+ " \n");
    }
    
}