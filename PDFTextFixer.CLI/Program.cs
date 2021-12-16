using PDFTextFixer.CLI;


var options = new Options(args);

IInputOutput inputOutput = options.PdfFileName != null 
    ? new FileInputOutput(options.PdfFileName) 
    : new ClipboardInputOutput();

inputOutput.ReturnText(PdfTextFixer.Fix(inputOutput.GetText()));