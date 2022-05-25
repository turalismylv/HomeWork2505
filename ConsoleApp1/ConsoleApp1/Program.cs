using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tapşırıq: simple schoolmanagement appi:
            //User və Student classınız var.
            //    User classında Name Surname Username Password propertyləri var.
            //    Student classında isə yuxarıdakı propertylərdən əlavə Grade propertysi də var.
            //Özünüzdə User arrayi saxlayıb içində bir neçə data saxlayın.
            //    App run olanda istifadəçidən username və passvord istəyin. 
            //    Əgər daxil edilən username və passvorddə olan user vardırsa və bu user studentdirsə,
            //    Grade - i ekrana çap olunsun.     
            Console.WriteLine("Username qeyd edin");
            string username = Console.ReadLine();

            Console.WriteLine("Password qeyd edin");
            string password = Console.ReadLine();

            User[] users = { new Student("Tural", "Ismayilov", "turalismylv", "tural123", "A"),
                             new Student("Murad", "Alcanov", "muradacn", "murad123", "B"),
                             new User("Emil", "Quluzade", "emilquluzade", "emil123") };




            bool flag = false;
            foreach (var item in users)
            {
                if (username == item.Username && password == item.Password)
                {
                    flag = true;                    
                        item.WhoIs();
 
                }
            }
            if (!flag) Console.WriteLine("Bu username ve passwordda User yoxdur!");
        }
    }
}
