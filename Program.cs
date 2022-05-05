using System;  
using System.Text;
using System.Collections.Generic;

namespace ConsoleApp7  
{  
  class personalAccount
  {  
    String accountName;
    String password;

    public personalAccount(string accountName, string password){
      this.accountName = accountName;
      this.password = password;
    }

    public string getAccountName(){
      return accountName;
    }

    public string getPassword(){
      return password;
    }
  }  

  class main{
    static void Main(string[] args)  
    {  
      // var generator = new RandomGenerator();  
      // var randomNumber = generator.RandomNumber(5, 100);  
      // Console.WriteLine($"Random number between 5 and 100 is {randomNumber}");  
  
      // var randomString = generator.RandomString(10);  
      // Console.WriteLine($"Random string of 10 chars is {randomString}");  
  
      // var randomPassword = generator.RandomPassword();  
      // Console.WriteLine($"Random string of 6 chars is {randomPassword}");  
  
      // Console.ReadKey();
      personalAccount newAccount;
      List<personalAccount> accountList = new List<personalAccount>();

      void viewPersonalAccounts(){
        for(int i=0; i<accountList.Count;i++){
          Console.WriteLine(accountList[i]);
        }
      }

      void addNewAccount(){
        Console.WriteLine("Enter Account Name:");
        var newAccount = Console.ReadLine();

        Console.WriteLine("Enter Account Password:");
        var newPassword = Console.ReadLine();

        accountList.Add(new personalAccount($"{newAccount}",$"{newPassword}"));
        Console.WriteLine("Added new account details!");
      }

      void printOptions(){
        Console.WriteLine("Please select one of the following options:");
        Console.WriteLine("1. Peronal Accounts");
        Console.WriteLine("2. Add new account");

        string userChoice = Console.ReadLine().ToString();

        if(userChoice == "1"){
          Console.WriteLine("Here are you stored accounts...");
          viewPersonalAccounts();
        } else if(userChoice == "2"){
          Console.WriteLine("Creating new account...");
          addNewAccount();
        } else {
          Console.WriteLine("Press any key to exit...");
        }
      }  
      
      printOptions();
    }  
  }
  


  //Creates random passwords
  public class RandomGenerator  
  {  
    private readonly Random _random = new Random();  
    
    public int RandomNumber(int min, int max)  
    {  
      return _random.Next(min, max);  
    }  
     
    public string RandomString(int size, bool lowerCase = false)  
    {  
      var builder = new StringBuilder(size);  
   
      char offset = lowerCase ? 'a' : 'A';  
      const int lettersOffset = 26;
  
      for (var i = 0; i < size; i++)  
      {  
        var @char = (char)_random.Next(offset, offset + lettersOffset);  
        builder.Append(@char);  
      }  
  
      return lowerCase ? builder.ToString().ToLower() : builder.ToString();  
    }  
  
    public string RandomPassword()  
    {  
      var passwordBuilder = new StringBuilder();  
  
      passwordBuilder.Append(RandomString(4, true));  
  
      passwordBuilder.Append(RandomNumber(1000, 9999));  
  
      passwordBuilder.Append(RandomString(2));  
      return passwordBuilder.ToString();  
    }  
  }  
} 