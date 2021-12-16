namespace PDFTextFixer.CLI;

public interface IInputOutput
{
    string GetText();
    void ReturnText(string text);
}