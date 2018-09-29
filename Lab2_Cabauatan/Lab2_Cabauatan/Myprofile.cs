
namespace Lab2_Cabauatan
{
    class Myprofile
    {
        public string Name, Program, Year;
        System.DateTime DOB;
        public void MyProfileDetails()
        {
            System.Console.Write("Enter your name <lastname, firstname> ");
            Name = System.Console.ReadLine();
            System.Console.Write("Enter your name Program               ");
            Program = System.Console.ReadLine();
            System.Console.Write("Enter your year level                 ");
            Year = System.Console.ReadLine();
            System.Console.Write("Enter your date of birth              ");
            DOB = System.Convert.ToDateTime(System.Console.ReadLine());
            System.Console.Write("\n\n\n====================Displaying the data====================");
            System.Console.Write("\n\n\nName: " + Name);
            System.Console.Write("\nProgram: " + Program);
            System.Console.Write("\nYear Level: " + Year);
            System.Console.Write("\nBirthday: " + DOB.ToString("MM/dd/yyyy") + "\n");
            System.Console.ReadKey();
        }
    }
}
