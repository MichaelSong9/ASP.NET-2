using System;

namespace Cap03_ExComplem04
{
    class mensagemCortesia
    {
        static void Main(string[] args)
        {
            if (DateTime.Now.Hour > 17)
            {
                Console.WriteLine("Boa noite");
            }
            else if (DateTime.Now.Hour > 11)
            {
                Console.WriteLine("Boa tarde");
            }
            else
            {
                Console.WriteLine("Bom dia");
            }
        }
    }
}
