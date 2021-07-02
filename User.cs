using System;


namespace Math_Utility_App
{
    class User
    {
        public static string SetUser()
        {
            Console.Write("\n Please Enter your Name: "); 
            string userName = Console.ReadLine();
           
            //If user does not enter name, assign name as Guest
            if (userName == "")
            {
                userName = "Guest";
            }
            return userName;
        }
    }      
}
