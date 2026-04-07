
using System;
using System.IO;
using System.Threading.Tasks;
namespace Exam_4;

class Program
{
    static void Main(string[] args)
    {
        var botService = new BotService();
        botService.Start();

        Console.ReadLine();
    }
}
