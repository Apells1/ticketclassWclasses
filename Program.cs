using System;
using System.Collections; 
using System.IO;
using System.Text;
namespace ticketClasser
{
    class Cvs
    {
        string filename = "";
         ArrayList Id11 = new ArrayList();
         ArrayList summary11 = new ArrayList();
         ArrayList status11 = new ArrayList();
         ArrayList priority11 = new ArrayList();
         ArrayList submitter11 = new ArrayList();
         ArrayList assigned11 = new ArrayList();
         ArrayList watching11 = new ArrayList();
        string Id1 = "";

        string summary1 = "";
        string status1 = "";
        string priority1 = "";
        string submitter1 = "";
        string assigned1 = "";
        string watching1 = "";
       public void setArray(string id, string summary, string status, string priority, string submitter, string assigned, string watching){
        //    Id1.Add(id);
        //      status1.Add(status);
        //      priority1.Add(priority);
        //      submitter1.Add(submitter);
        //      assigned1.Add(assigned);
        //      watching1.Add(watching);
        Id1 = id;
        summary1 = summary;
        status1 = status;
        priority1 = priority;
        submitter1 = submitter;
        assigned1 = assigned;
        watching1 = watching;
       }

       public void createFile(string name){
           filename = name+".txt";
            using (StreamWriter sw = File.CreateText(filename));
       }

       public void writeFile(string filenamer){
           try{ using (StreamWriter sw = new StreamWriter(filenamer, true, Encoding.Unicode))
            {
               //i can also just have an array as a parameter then join it together to make the watching bit

                 sw.WriteLine(Id1+","+summary1+","+status1+","+priority1+","+submitter1+","+assigned1+","+watching1);
                 
            }}
            catch(Exception){
                Console.WriteLine("no file found!");
            }
          
       }
    //maybe also add a try block in case there is nothing in the strings or some other error
       public void readFile(string filenamer){
           try{
                using(StreamReader sr = new StreamReader(filenamer)) {
                    
                 while(!sr.EndOfStream) {
                 string reader = sr.ReadLine();
                   string[] completeTicket = reader.Split(',');
                    Id11.Add(completeTicket[0]);
                    summary11.Add(completeTicket[1]);
                    status11.Add(completeTicket[2]);
                    priority11.Add(completeTicket[3]);
                    submitter11.Add(completeTicket[4]);
                    assigned11.Add(completeTicket[5]);
                    watching11.Add(completeTicket[6]);

                 
    }
    
  }
           }
           catch(Exception){Console.WriteLine("cannot find file!");}
          
       }
       public void displayFile(){
           if(Id11 != null){
                for(int x = 0; x < Id11.Count; x++){
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("Ticket Id: "+Id11[x]);
                    Console.WriteLine("Ticket Summary: "+Id11[x]);
                    Console.WriteLine("Ticket Status: "+status11[x]);
                    Console.WriteLine("Ticket Submitter: "+submitter11[x]);
                    Console.WriteLine("Ticket Assigned To: "+assigned11[x]);
                    Console.WriteLine("Ticket Watchers: "+watching11[x]);
                    Console.WriteLine("----------------------------------");
                }
               
           }
       }

     

            // add a getter and setter class for the parts of the file, a class for creating the file, one for reading from it, one for writing to it and a final one for displaying
        
    }
}
