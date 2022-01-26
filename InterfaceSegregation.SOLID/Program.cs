Document doc = new Document("23232", "MyDocx", "My First Doc");
doc.Print();
doc.CancelPrinting();

doc.Print("New Id 2323");
doc.Print("2323", "Overloaded doc");
doc.Print("2323", "Overloaded doc", "overloaded content");