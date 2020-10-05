using System;
using System.IO;
using System.Collections; 
using static ticketClasser.Cvs;
using System.Text;
namespace projectFinale
{
    class program
    {
        //add static to void main
       static void Main(string[] args)
        {
          string Id = "";
          string summary = "";
          string status = "";
          string priority = "";
          string submitter = "";
          string assigned = "";
          string watching = "";
          ArrayList watchers = new ArrayList();
          string line = "";
           ticketClasser.Cvs cvs =new ticketClasser.Cvs();
         
           string userChoice;

           do {
                Console.WriteLine("Please press 1 to create a cvs file, 2 to write to a cvs file, 3 to read from a cvs file, or any other number to quit");
                userChoice = Console.ReadLine();

                if (userChoice == "1"){
                    Console.WriteLine("Enter the name of the new file");
                  string userFile;
                  userFile = Console.ReadLine();
                cvs.createFile(userFile);

                } else if (userChoice == "2"){
                    Console.WriteLine("what is the name of the file you plan on writing to? (please include the .txt)");
                    string filename = Console.ReadLine();
                     Console.WriteLine("what is the ticket Id?)");
                     Id = Console.ReadLine();
                     Console.WriteLine("what is the ticket summary?)");
                     summary = Console.ReadLine();
                     Console.WriteLine("what is the ticket status?)");
                     status = Console.ReadLine();
                     Console.WriteLine("what is the ticket priority?)");
                     priority = Console.ReadLine();
                     Console.WriteLine("who is the ticket submitter?)");
                     submitter = Console.ReadLine();
                     Console.WriteLine("who assigned the ticket?)");
                     assigned = Console.ReadLine();

                     do{ Console.WriteLine("who is watching the ticket? keep typing names and press -1 when done)");
                     line = Console.ReadLine();
                     if(line != "-1"){
                         watchers.Add(line);
                     }
                     
                     }
                     while(line != "-1");
                      watching = string.Join("|", (string[])watchers.ToArray(Type.GetType("System.String")));
                    // Console.WriteLine(watching);

                    cvs.setArray(Id, summary, status, priority, submitter, assigned, watching);
                    cvs.writeFile(filename);
                }

        
                   if(userChoice == "3"){
                       Console.WriteLine("Whats the name of the file you wish to read from? (please include the .txt)");
                         string filename = Console.ReadLine();
                       cvs.readFile(filename);
                       cvs.displayFile();
                      }

            } while(userChoice == "1" || userChoice == "2" || userChoice == "3");
        }
    }
}