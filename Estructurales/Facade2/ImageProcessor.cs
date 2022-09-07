public class ImageProcessor{

    FileManager fileManager { get; set; }

    public ImageProcessor(FileManager fileManager)
    {
        this.fileManager = fileManager;
    }

    public void Process(){
        Console.WriteLine("Utilizando ImageProcessor");
        fileManager.Process();
    }

}