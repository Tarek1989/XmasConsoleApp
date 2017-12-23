using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace XmasConsoleAPP
{
    public class XmasApp
    {
        Timer t;
        
        public XmasApp()
        {
            Start();
        }

        private void Start()
        {
            t = new Timer(); // Instantiating the class Timer
            t.Elapsed += XmasTree; // using the elapse event handler that uses time in an incremental method based on the XmasTree method
            t.Interval = 1000; // Time interval 1000m/sec
            t.Enabled = true; 
            t.Start();

        }

        private  void XmasTree(object sender, ElapsedEventArgs e)
        {


            if (DateTime.Now.Minute == 39)
            {
                t.Stop();
                int x = 20, y, z;

                Console.WriteLine("::::::::::::::: Merry Xmas :::::::::::::::");


                for (int i = 1; i <= x; i++) // Total number of layer for pramid

                {

                    for (y = 1; y <= (x - i); y++)  // Loop For Space
                        
                        Console.Write(" ");
                    

                    for (z = 1; z <= i; z++) //increase the value

                        if (z % 2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("@");
                           
                        }
                        
                        
                        else 
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("*");
                        }

                    for (z = (i - 1); z >= 1; z--)  //decrease the value

                        if (z % 2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("@");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("*");
                        }

                    
                    Console.WriteLine();

                }
                
            }
            else
            {
               
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(50, 15);// makes it one line (timer) instead of one per line
                Console.WriteLine(DateTime.Now);
            }
        }

    }
}
