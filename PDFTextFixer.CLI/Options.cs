namespace PDFTextFixer.CLI;

public class Options
{
    private readonly string[] _args;

    public Options(string[] args) => _args = args;

    public string? PdfFileName => _args.Length > 0 ? _args[0] : null;
}