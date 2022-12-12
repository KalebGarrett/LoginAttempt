using System;

namespace LoginAttempt
{
    class Program
    {
        //The following program allows you to create a username and password.
        //You get 3 attempts to input your username and password correctly or 
        //you will be locked out of your account.
        static void Main(string[] args)
        {
            Credentials credentials = new Credentials();
            credentials.createCredentials();
            do
            {
                credentials.loginCredentials();
                credentials.loginCounter();
            } while ((credentials.loginUsername != credentials.userName || credentials.loginPassword != credentials.passWord) && credentials.attempt != 3);
            
            credentials.attemptMax();
        }
    }
}