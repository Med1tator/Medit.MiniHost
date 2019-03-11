using System;

namespace Medit.MiniClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new PlayServiceClient())
            {
                client.Play();
                Console.ReadKey();
            }
        }
    }
}
