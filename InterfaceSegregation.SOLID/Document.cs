public class Document : IPrint
{
    private readonly string _documentId;
    private readonly string _documentName;
    private readonly string _content;
    public Document(string documentId, string documentName, string content)
    {
        _documentId = documentId;
        _documentName = documentName;
        _content = content;
    }


    public void Print()
    {
        Console.WriteLine("Printing the Doc with the Id {0}", _documentId);
        Console.WriteLine("Printing the Doc with the Name {0}", _documentName);
        Console.WriteLine("Printing the Doc with the Content {0}", _content);
    }

    public void Print(string id)
    {
        Console.WriteLine("Printing the Doc with the Id {0}", id);
        Console.WriteLine("Printing the Doc with the Name {0}", _documentName);
        Console.WriteLine("Printing the Doc with the Content {0}", _content);
    }


    public void Print(string id, string documentName)
    {
        Console.WriteLine("Printing the Doc with the Id {0}", id);
        Console.WriteLine("Printing the Doc with the Name {0}", documentName);
        Console.WriteLine("Printing the Doc with the Content {0}", _content);
    }

    public void Print(string id, string documentName, string content)
    {
        Console.WriteLine("Printing the Doc with the Id {0}", id);
        Console.WriteLine("Printing the Doc with the Name {0}", documentName);
        Console.WriteLine("Printing the Doc with the Content {0}", content);
    }

    public void CancelPrinting()
    {
        Console.Write("Printing cancelled");
    }
}