namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name :");
            var name = Console.ReadLine();
            Console.WriteLine("Surname :");
            var surname = Console.ReadLine();
            Console.WriteLine("Username :");
            var username = Console.ReadLine();
            Console.WriteLine("Password :");
            var password = Console.ReadLine();
            user user = new user(name,surname,username,password);
            user.age = 20;
            user.ShowFullData();


        }
    }
}
