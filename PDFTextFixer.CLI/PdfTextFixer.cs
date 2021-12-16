using System.Text;

namespace PDFTextFixer.CLI;

public class PdfTextFixer
{
    public static string Fix(string text)
    {
        text = text.ReplaceLineEndings("\n").Replace("\n\n", "\n");
        StringBuilder sb = new StringBuilder(text.Length);
        int i = 0;
        while(i < text.Length - 2)
        {
            var (c1, c2, c3) = (text[i], text[i + 1], text[i + 2]);
            if (c2 != '\n')
            {
                sb.Append(c1);
                i++;
                continue;
            }

            if (c1 == '-')
            {
                sb.Append(c3);
            }
            else
            {
                sb.Append(c1);
                if (c1 == '.' || char.IsDigit(c3)) 
                    sb.Append(c2);
                sb.Append(c3);
            }
            i += 3;
        }

        return sb.ToString();
    }
        
}