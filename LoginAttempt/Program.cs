using System;

namespace LoginAttempt
{
    class Program
    {
        //The following program allows you to input a username and password based
        //off the variables userName and passWord under the Credentials class.
        static void Main(string[] args)
        {
            Credentials credentials = new Credentials();

            do
            {
                credentials.loginCredentials();
                credentials.loginCounter();
            } while ((credentials.loginUsername != credentials.userName || credentials.loginPassword != credentials.passWord) && credentials.attempt != 3);
            
            credentials.attemptMax();
        }
    }
}