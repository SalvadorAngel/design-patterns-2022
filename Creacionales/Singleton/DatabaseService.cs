public class DatabaseService{

    private DatabaseService(){}

    public List<string> getScoreList(){
        return new List<string>{
            "Player1: 10000",
            "Player2: 10000",
            "Player3: 10000",
            "Player4: 10000",
        };
    }

    private static DatabaseService? _instance { get; set; }


    public static DatabaseService getInstance(){
        if(_instance is null){
            _instance = new DatabaseService();
        }
        return _instance;
    }

}