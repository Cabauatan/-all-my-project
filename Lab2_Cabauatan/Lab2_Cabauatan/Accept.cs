
namespace Lab2_Cabauatan
{
    class Accept
    {
        public string firstname, lastname;

        public void AcceptDetails()
        {
            System.Console.WriteLine("Enter your name <firstname lastname> ");
            firstname = System.Console.ReadLine();
            lastname = System.Console.ReadLine();
        }
    }
}
