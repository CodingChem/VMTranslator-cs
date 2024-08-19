namespace VMTranslator;

using VMTranslator.Lib;
using VMTranslator.Lib.CodeWriter;
using VMTranslator.Lib.Parser;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.WriteLine("Usage: VMTranslator <file.vm>");
            return;
        }
        try
        {
            var translator = new Translator(args[0], new ParserFactory(), new CodeWriterFactory());
            translator.Translate();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
