<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>xunit</NuGetReference>
  <NuGetReference>xunit.runner.visualstudio</NuGetReference>
  <CopyLocal>true</CopyLocal>
</Query>

class Solution
{

    static int RollingDieFaceValue (int currentPlyIdx, Dictionary<int, int> ladder, Dictionary<int, int> snake, Dictionary<int, int> playerPos)
    {
        Random rollingdie = new Random();
        int dievalue = rollingdie.Next (1, 7);

        int currentFaceValue = playerPos [currentPlyIdx];
        Console.Write("({0}, {1})  ", dievalue, currentFaceValue);
        int nextFaceValue = currentFaceValue + dievalue;

        if (nextFaceValue == 100)
        {
            return 100;
        }
        if(nextFaceValue >100){
            return nextFaceValue - dievalue;
        }

        if (ladder.ContainsKey (nextFaceValue))
        {
            nextFaceValue = ladder [nextFaceValue];
        }
        if (snake.ContainsKey (nextFaceValue))
        {
            nextFaceValue = snake [nextFaceValue];
        }

        playerPos [currentPlyIdx] = nextFaceValue;
        return nextFaceValue;
    }

    static void Main (String[] args)
    {


        Dictionary<int, int> ladder = new Dictionary<int, int>();
        Dictionary<int, int> snake = new Dictionary<int, int>();
        Dictionary<int, int> playerPos = new Dictionary<int, int>();

        ladder.Add (4, 22);
        ladder.Add (46, 67);
        ladder.Add (51, 90);


        snake.Add (92, 35);
        snake.Add (71, 55);
        snake.Add (62, 21);

        int count = 1;
        int numPlayers = Convert.ToInt32 (Console.ReadLine());

        for (int i = 1; i <= numPlayers; i++)
        {
            playerPos.Add (i, 1);
        }

        int currentIdx = 1;
        while (true)
        {
            Console.WriteLine ("Player Turn: {0}", currentIdx);
            int RollingDieValue = RollingDieFaceValue (currentIdx, ladder, snake, playerPos);

            if (RollingDieValue == 100)
            {
                Console.WriteLine ("Winner: Player {0} ", currentIdx);
                break;
            }
            else
            {
                Console.WriteLine ("Rolled die, face value : {0}", RollingDieValue);
            }
            currentIdx++;

            if (currentIdx > numPlayers)
            {
                currentIdx = 1;
            }
        }
    }
}

// Define other methods, classes and namespaces here
