
namespace Lab2_Cabauatan
{
    class Print
    {
        public void PrintDetails()
        {
            Accept a = new Accept();
            a.AcceptDetails();

            System.Console.Write("\nHello " + a.firstname + " " + a.lastname + "!!!\nYou have created classes in OOP\n\n");
            Myprofile mp = new Myprofile();
            mp.MyProfileDetails();
        }
    }
}
