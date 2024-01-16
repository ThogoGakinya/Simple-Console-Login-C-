namespace Simple_Reg
{
    internal class Program
    {
        static string userName = "";
        static string passWord = "";
        static bool isRegisterd = false;
        static void Main(string[] args)
        {
            Register();
            Login();
        }

        public static void Register()
        {
            if (!isRegisterd)
            {
                Console.WriteLine("REGISTRATION");
                Console.WriteLine("Enter Username");
                userName = Console.ReadLine();
                Console.WriteLine("Enter Password");
                passWord = Console.ReadLine();
                isRegisterd = true;
                Login();
            }
            else
            {
                Login();
            }
        }

        public static void Login() 
        {
            Console.WriteLine("LOGIN");
            Console.WriteLine("Please Enter username");
            string enterdUserName = Console.ReadLine();
            if (enterdUserName != userName)
            {
                Console.WriteLine("Wrong Username");
            }
            else
            {
                Console.WriteLine("Enter Password");
                string enterdPassword = Console.ReadLine();
                if (enterdPassword != passWord)
                {
                    Console.WriteLine("Wrong Password");
                }
                else 
                {
                    Console.WriteLine("Successfully logged in");
                }
            }
        }
    }
}
