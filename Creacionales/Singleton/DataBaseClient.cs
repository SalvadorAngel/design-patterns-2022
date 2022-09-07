public class DataBaseConsumer : IConsumer
{
    // TODO refactorizar para implementar uso de singleton
    public void runClient()
    {

        Console.WriteLine("Ejecución database service.");

        DatabaseService databaseService = new DatabaseService();

        List<string> scores = databaseService.getScoreList();

        foreach (var it in scores)
        {
            Console.WriteLine(it);
        }
        
    }
}