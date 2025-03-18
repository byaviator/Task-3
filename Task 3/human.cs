using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3;

class human
{
    public string name;
    public string surname;
    private byte _age;
    public byte age
{
    get { return _age; }
    set { _age = value; }
}

    public human()
    {
       
    }

    public human(string name)
    {
        this.name = name;
        
    }

    public human(string name, string surname )
    {
        this.name = name;
        this.surname = surname;
    }


    public void ShowFullData()
    {
        Console.WriteLine($" Name : {name}\n Surname : {surname}\n Age : {age}");
    }

    public string GetFullName()
    {
        return $"{name} {surname}";
    }
}



class user :human
{
    public string UserName;
    public string Password;


    public user(string name,string surname,string username,string password) : base(name,surname)
    {
        if (username.Length <6 || username.Length >25)
            Console.WriteLine(username);
        if (password.Length < 8 || password.Length > 25)
            Console.WriteLine(password);

        UserName = username;
        Password = password;

    }
   

}
 




