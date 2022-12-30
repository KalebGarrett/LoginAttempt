using System;

namespace LoginAttempt
{
    class Program
    {
        /*
            The following program allows you to create a username and password.
            You get 3 attempts to input your username and password correctly or 
            you will be locked out of your account.
        */
        static void Main(string[] args)
        {
            Credentials credentials = new Credentials();
            credentials.CreateCredentials();
            do
            {
                Console.WriteLine();
                credentials.LoginCredentials();
                credentials.LoginCounter();
            } while ((credentials.loginUsername != credentials.createUserName || credentials.loginPassword != credentials.createPassWord) && credentials.attempts != 3);
            credentials.AttemptMax();
        }
    }
}