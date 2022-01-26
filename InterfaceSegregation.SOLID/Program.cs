using static System.Console;


Document doc = new Document("23232", "MyDocx", "My First Doc");
doc.Print();
doc.CancelPrinting();

doc.Print("New Id 2323");
doc.Print("2323", "Overloaded doc");
doc.Print("2323", "Overloaded doc", "overloaded content");


public interface IPrint
{
    void Print();
    void CancelPrinting();
}


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
        WriteLine("Printing the Doc with the Id {0}", _documentId);
        WriteLine("Printing the Doc with the Name {0}", _documentName);
        WriteLine("Printing the Doc with the Content {0}", _content);
    }

    public void Print(string id)
    {
        WriteLine("Printing the Doc with the Id {0}", id);
        WriteLine("Printing the Doc with the Name {0}", _documentName);
        WriteLine("Printing the Doc with the Content {0}", _content);
    }


    public void Print(string id, string documentName)
    {
        WriteLine("Printing the Doc with the Id {0}", id);
        WriteLine("Printing the Doc with the Name {0}", documentName);
        WriteLine("Printing the Doc with the Content {0}", _content);
    }

    public void Print(string id, string documentName, string content)
    {
        WriteLine("Printing the Doc with the Id {0}", id);
        WriteLine("Printing the Doc with the Name {0}", documentName);
        WriteLine("Printing the Doc with the Content {0}", content);
    }

    public void CancelPrinting()
    {
        Write("Printing cancelled");
    }
}
