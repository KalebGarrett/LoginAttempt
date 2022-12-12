﻿using System;

namespace LoginAttempt
{
    public class Credentials
    {
        public int attempt = 0;
        public string userName;
        public string passWord;
        public string loginUsername;
        public string loginPassword;
        
        public void createCredentials()
        {
            Console.Write("Create a username: ");
            userName = Console.ReadLine();
            Console.Write("Create a password: ");
            passWord = Console.ReadLine();
        }
        
        public void loginCredentials()
        {
            Console.Write("Enter your username: ");
            loginUsername = Console.ReadLine();
            Console.Write("Enter your password: ");
            loginPassword = Console.ReadLine();
            
            if (loginUsername != userName)
            {
                Console.WriteLine("You have submitted an incorrect username! Try again.");
            }
            
            if (loginPassword != passWord)
            {
                Console.WriteLine("You have submitted an incorrect password! Try again.");
            }
        }

        public void loginCounter()
        {
            if (loginUsername != userName || loginPassword != passWord)
            {
                attempt++;
            }
            else
            {
                attempt = 1;
            }
        }
        
        public void attemptMax()
        {
            if (attempt == 3)
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