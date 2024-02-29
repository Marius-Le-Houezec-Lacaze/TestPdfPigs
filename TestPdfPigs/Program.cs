

using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;

class Program
{
    static void Main(string[] args)
    {
        using (var document = PdfDocument.Open(@"C:\Test pdfs\test.pdf"))
        {
            foreach (var page in document.GetPages())
            {
                var words = page.GetWords();

                foreach (var word in words)
                {
                    Console.WriteLine(word.Text);
                    Console.WriteLine(word.BoundingBox.Right);
                    Console.WriteLine(word.BoundingBox.Left);
                }
                
            }
        }
    }
}