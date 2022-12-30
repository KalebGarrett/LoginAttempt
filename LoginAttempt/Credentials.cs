using System;

namespace LoginAttempt
{
    public class Credentials
    {
        public int attempts = 0;
        public string createUserName;
        public string createPassWord;
        public string loginUsername;
        public string loginPassword;
        
        public void CreateCredentials()
        {
            Console.Write("Create a username: ");
            createUserName = Console.ReadLine();
            Console.Write("Create a password: ");
            createPassWord = Console.ReadLine();
        }
        
        public void LoginCredentials()
        {
            Console.Write("Enter your username: ");
            loginUsername = Console.ReadLine();
            Console.Write("Enter your password: ");
            loginPassword = Console.ReadLine();
            
            if (loginUsername != createUserName)
            {
                Console.WriteLine("You have submitted an incorrect username! Try again.");
            }
            
            if (loginPassword != createPassWord)
            {
                Console.WriteLine("You have submitted an incorrect password! Try again.");
            }
        }

        public void LoginCounter()
        {
            if (loginUsername != createUserName || loginPassword != createPassWord)
            {
                attempts++;
            }
            else
            {
                attempts = 1;
            }
        }
        
        public void AttemptMax()
        {
            if (attempts == 3)
            {
                Console.WriteLine("Login attempt reached three times. Try again later!");
            }
            else
            {
                Console.WriteLine("Login Successful!");
            }
        }
    }
}