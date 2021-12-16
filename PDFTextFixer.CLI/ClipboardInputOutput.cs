namespace PDFTextFixer.CLI;

public class ClipboardInputOutput : IInputOutput
{
    private readonly TextCopy.Clipboard _clipboard = new TextCopy.Clipboard();
        
    public string GetText() => _clipboard.GetText() ?? "";
    public void ReturnText(string text) => _clipboard.SetText(text);
}