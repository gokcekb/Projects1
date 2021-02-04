using System;

namespace OOP3
{
    class FilebaseLoggerService : IloggerService
{
    public void Log()
    {
        Console.WriteLine("Dosyaya loglandı");
    }
}
}