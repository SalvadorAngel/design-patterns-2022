public class Printer {
    public string DocType { get; set; }
    public string PageType { get; set; }
    public bool Color { get; set; }
    public string Text { get; set; }


    public void Print(){
        Console.WriteLine($"Documento {DocType} {(Color ? "a Color" : "en blanco y negro")} impreso desde Printer");
    }

}