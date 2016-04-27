using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4___Encrypt_the_Messages
{
    class Program
    {
       static char[] EncriptedMsg(char[] mesage)
        {
            for (int i = 0; i < mesage.Length; i++)
            {
                if (mesage[i] >= '0' && mesage[i]<='9')
                {
                    continue;
                }
                if (mesage[i]>='a'&&mesage[i]<='m')
                {
                    mesage[i] = (char)((int)'n' + (int)(mesage[i] - 'a')) ;
                    continue;
                }
                if (mesage[i] >= 'A' && mesage[i] <= 'M')
                {
                    mesage[i] = (char)((int)'N' + (int)(mesage[i] - 'A') );
                    continue;
                }
                if (mesage[i] >= 'n' && mesage[i] <= 'z')
                {
                    mesage[i] = (char)((int)'a' + (int)(mesage[i] - 'n'));
                    continue;
                }
                if (mesage[i] >= 'N' && mesage[i] <= 'Z')
                {
                    mesage[i] = (char)((int)'A' + (int)(mesage[i] - 'N'));
                    continue;
                }
                switch (mesage[i])
                {
                    case ' ':mesage[i] = '+';break;
                    case ',': mesage[i] = '%'; break;
                    case '.': mesage[i] = '&'; break;
                    case '?': mesage[i] = '#'; break;
                    case '!': mesage[i] = '$'; break;
                }
            }
            mesage = mesage.Reverse().ToArray();
            return mesage;
        }
        static void Main()
        {
            start:
            string start = Console.ReadLine();
            string mesageInput = "";
            List < string > output= new List<string>();
            int count = 0;
            if (start == "start" || start == "START")
            {
                goto mesage;
            }
            else goto start;
            mesage:
            while (true)
            {
                
                    mesageInput = Console.ReadLine();
                    char[] mesage = new char[mesageInput.Length];
                    if (mesageInput == "end" || mesageInput == "END" )
                    {
                        break;
                    }
                    mesage = mesageInput.ToArray();
                    output.Add(string.Join("", EncriptedMsg(mesage)));
                }
            for (int i = 0; i < output.Count; i++)
            {
                if (output[i]!="")
                {
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("No messages sent.");
            }
            else
            {
                Console.WriteLine("Total number of messages: {0}", count);
                foreach (var item in output)
                {
                    if (item!="")
                    {
                        Console.WriteLine(item);
                    }
                    
                }
            }
        }
    }
}
