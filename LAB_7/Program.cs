using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LAB_7
{
    class Program
    {
        static void Main(string[] args)
        {
#if !DEBUG
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"graph_output.txt");
            var new_in = new StreamReader(@"graph_input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in); 
#endif
            Graph g1, g2;
#if DEBUG
            g1 = new Graph(6, 17);
            g1.Info(ConsoleColor.Red, ConsoleColor.White);
#endif

#if !DEBUG
            g1 = Graph.createGraphFromFile();
            g1.Info();
            g2 = new Graph(3.4, 13.2);
            g2.Info();
#endif

#if !DEBUG
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
#endif

#if DEBUG
            Console.ReadKey();
#endif
        }
    }
}
