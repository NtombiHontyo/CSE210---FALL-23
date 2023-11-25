using System;

class Program
{
    static void Main(string[] args)
    {
       // Console.Write(@"\");
        //Thread.Sleep(500);
        //Console.Write("\b \b");
        //Console.Write("|");

        List<char> charList = new List<char>();

        charList.Add('\\');
        charList.Add('|');
        charList.Add('/');
        charList.Add('-');
        charList.Add('\\');

        Console.WriteLine();
        //foreach (char charecter in charList)
        //{
          //  Console.Write(charecter);
            //Thread.Sleep(500);
            //Console.Write("\b \b");
        //}

        //Console.WriteLine();

        List<char> countdown = new List<char>();

        countdown.Add('5');
        countdown.Add('4');
        countdown.Add('3');
        countdown.Add('2');
        countdown.Add('1');

        Console.WriteLine();
        

        //Working with time

        DateTime currentTime = DateTime.Now;
        DateTime FutureTime = currentTime.AddSeconds(5);
        int i =0; 
       // Thread.Sleep(3000);

        while (DateTime.Now < FutureTime)
        {
            //foreach (char charecter in charList)
            //    {
           //         Console.Write(charecter);
            //        Thread.Sleep(500);
            //        Console.Write("\b \b");
            //    }

                //OR   
            char s = charList[i]  ;
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= charList.Count)
            {
                i = 0;
            }  
        }
        
        
    }
}
