public class Facade1Cliente : IConsumer
{
    // TODO implementa el patron de diseño Facade
    // TODO Generar por lo menos 3 facades con distintos tipos de impresoras
    public void runClient()
    {

        Console.WriteLine("Ejecución Facade1Cliente.");

        Printer colorPdfPrinter = new Printer();
        colorPdfPrinter.Color = true;
        colorPdfPrinter.PageType = "a4";
        colorPdfPrinter.Text = "prueba.pdf";
        colorPdfPrinter.DocType = "PDF";

        Printer bnPdfPrinter = new Printer();
        bnPdfPrinter.Color = false;
        bnPdfPrinter.PageType = "a4";
        bnPdfPrinter.Text = "prueba.pdf";
        bnPdfPrinter.DocType = "PDF";

        colorPdfPrinter.Print();
        // bnPdfPrinter.Print();

        
        // TODO agregar menu para seleccionar cual tipo de impresora utilizar
        
    }
}