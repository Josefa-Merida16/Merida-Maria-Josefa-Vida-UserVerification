using UserBL;
namespace UserUI1
{
    internal class Program1
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Enter your username: ");
                string username = Console.ReadLine();

                Console.Write("Enter your password: ");
                string password = Console.ReadLine();


                Class3 verified = new Class3();
                bool result = verified.UserVerify(username, password);


                if (result)
                {
                    Console.WriteLine("WELCOME! YOU HAVE BEEN VERIFIED");
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
            }
        }
    }
}
