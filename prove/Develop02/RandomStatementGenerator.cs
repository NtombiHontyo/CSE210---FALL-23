public class RandomStatementGenerator
{
    public List<string>_questions = new List<string>();


    public string GenerateRandomStatement()
    {
        Random randomgenerator = new Random();
        int randomIndex = randomgenerator.Next(1, _questions.Count);
        string randomStatement;
        return  randomStatement = _questions[randomIndex];
        
    }
    
}