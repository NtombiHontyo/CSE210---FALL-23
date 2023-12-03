public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    public GoalManager()
    {
        _goals = new List<Goal>();
        
        _score = 0;
    }
    public void Start()
    {

        string menuChoice = "";
        while (menuChoice != "6")
        {
         DisplayPlayerInfo();
         Console.WriteLine();   
        Console.WriteLine("Menu Options");
        Console.WriteLine("1. Create New Goal \n2. List Goals \n3. Save Goals\n4. Load Goals \n5. Record Event \n6. Quit");
        Console.Write("Select a choice from the menu: ");
        menuChoice = Console.ReadLine();

        if (menuChoice == "1")
        {
            CreateGoal();
        }
        else if (menuChoice == "2")
        {
            ListGoalDetails();
        }
        else if(menuChoice == "3")
        {
            Console.Write("What is the name of the file that you want to save to?");
            string fileName = Console.ReadLine();
            SaveGoals(fileName);
        }
        else if (menuChoice == "4")
        {
            Console.Write("What is the name of the file that you would like to load from?");
            string fileName = Console.ReadLine();
            LoadGoals(fileName);
        }
        else if (menuChoice == "5")
        {
            RecordEvent();
        }
        }
        
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }
    public void ListGoalNames()
    {
        int index = 1;
        foreach (Goal goal in _goals)
        {
            string name = goal.GetName();
            Console.WriteLine($"{index}. {name}");
            index++;
        }

    }
    public void ListGoalDetails()
    {
        int index = 1; 
        foreach (Goal goal in _goals)
        { 
            Console.WriteLine($"{index}. {goal.GetDetailsString()}");
            index++;
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are: \n1. Simple Goal \n2. Eternal Goal \n3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalTypeChoice = Console.ReadLine();

        if (goalTypeChoice == "1")
        {
            Console.Write("What is the name of your goal? ");
        string nameAnswer = Console.ReadLine();
        Console.Write("What is the description of it? ");
        string descriptionAnswer = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string pointsString = Console.ReadLine();
        int points = int.Parse(pointsString);
        SimpleGoal simpleGoal = new SimpleGoal(nameAnswer, descriptionAnswer, points);
        simpleGoal.SetPoints(points);
        _goals.Add(simpleGoal);
        
        }
        else if (goalTypeChoice == "2")
        {
            Console.Write("What is the name of your goal? ");
        string nameAnswer = Console.ReadLine();
        Console.Write("What is the description of it? ");
        string descriptionAnswer = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string pointsString = Console.ReadLine();
        int points = int.Parse(pointsString);
        EternalGoal eternalGoal = new EternalGoal(nameAnswer, descriptionAnswer, points);
        eternalGoal.SetPoints(points);
        _goals.Add(eternalGoal);
        
        }
        else if (goalTypeChoice == "3")
        {
            Console.Write("What is the name of your goal? ");
        string nameAnswer = Console.ReadLine();
        Console.Write("What is the description of it? ");
        string descriptionAnswer = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string pointsString = Console.ReadLine();
        int points = int.Parse(pointsString);
        ChecklistGoal checklistGoal = new ChecklistGoal(nameAnswer, descriptionAnswer, points);
        checklistGoal.SetPoints(points);
        _goals.Add(checklistGoal);
       
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("The Goals are: ");
        ListGoalNames();
        Console.Write("Which goal did you acccomplish?");
        string answer = Console.ReadLine();
        int goalAccomplished = int.Parse(answer);
        Goal goal = _goals[goalAccomplished - 1];
        goal.RecordEvent();
        _score += goal.GetPoints();
        Console.WriteLine($"You now have {_score} points");
    }
    public void SaveGoals(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Goal entry in _goals)
            {
                outputFile.WriteLine($"{entry.GetDetailsString()}");
            }
            
        }
    }
    public void LoadGoals(string fileName)
    {
         string[] lines = System.IO.File.ReadAllLines(fileName);

foreach (string line in lines)
{
    string[] parts = line.Split(":");

    string nameOfGoal = parts[0];
    string goalDescription = parts[1];

    Console.WriteLine($"{nameOfGoal} - {goalDescription}");
    }
    }
}