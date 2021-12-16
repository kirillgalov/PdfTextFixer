using BitMiracle.Docotic.Pdf;

namespace PDFTextFixer.CLI;

public class FileInputOutput : IInputOutput
{
    private readonly string _fileName;

    public FileInputOutput(string fileName) => _fileName = fileName;

    public string GetText()
    {
        if (!File.Exists(_fileName))
            throw new Exception($"File {_fileName} does not exist");
        if (!_fileName.EndsWith(".pdf"))
            throw new Exception($"File {_fileName} is not pdf");
        using var pdf = new PdfDocument(_fileName);
        return pdf.GetText();
    }

    public void ReturnText(string text)
    {
        string outputFile = _fileName + ".txt";
        File.WriteAllText(outputFile, text);
    }
}