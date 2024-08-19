namespace VMTranslator.Lib;

using VMTranslator.Lib.CodeWriter;
using VMTranslator.Lib.Parser;

public class Translator
{
    private readonly IParserFactory _parserFactory;
    private readonly ICodeWriter _codeWriter;

    public Translator(
        string filePath,
        IParserFactory parserFactory,
        ICodeWriterFactory codeWriterFactory
    )
    {
        //TODO: Implement
        throw new NotImplementedException();
    }

    public void Translate()
    {
        //TODO: Implement
        throw new NotImplementedException();
    }
}
