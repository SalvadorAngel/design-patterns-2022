public class AudioProcessor{

    FileManager fileManager { get; set; }

    public AudioProcessor(FileManager fileManager)
    {
        this.fileManager = fileManager;
    }

    public void Process(){
        Console.WriteLine("Utilizando AudioProcessor");
        fileManager.Process();
    }

}