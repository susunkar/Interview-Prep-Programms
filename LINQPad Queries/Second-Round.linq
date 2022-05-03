<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	
	var gc = new ScoreManger();
	while (true)
	{
		Console.WriteLine ("New Player: 1\nScoreIncrease:2\nList All Players:3\nTop 10 Players:4\nExit 0 ");
		var choice = Console.ReadLine();
		switch (choice){
			case "1": 
			Console.WriteLine("Enter the name: ");
			var name =  Console.ReadLine();
			gc.AddNewPlayer(name);
			break;
			case "2":
			Console.WriteLine("Enter the name: ");
			var n = Console.ReadLine();
			gc.IncrementPlayerScore(n);
			break;
			case "3": gc.GetAllPlayersScores().Dump(); break;
			case "4": gc.GetTopTenScorers().Dump(); break;
			default: return;
		}
		
	}
}



public class ScoreManger : IScoreManager
{
	Dictionary<string,int> playerScore = new Dictionary<string, int>();
	Dictionary<string, int> topScorePlayers = new Dictionary<string, int>();
	
	int defaultScore = 1;
	int defaultTopList = 10;
	
	public void AddNewPlayer(string playerId)
	{
		//Validate player
		if(ValidatePlayer(playerId)== false){
			playerScore.Add(playerId,defaultScore);
			CreateTopScoreList();
		}
	}

	public Dictionary<string, int> GetAllPlayersScores()
	{
		return playerScore;
	}

	public Dictionary<string, int> GetTopTenScorers()
	{
		return topScorePlayers;
	}

	public void IncrementPlayerScore(string playerId)
	{
		//Validation player
		if (ValidatePlayer(playerId) == true)
		{
			playerScore[playerId] += 1;
			CreateTopScoreList();
		}
		else{
			throw new ArgumentException("Invalid playerId, player is not playing");
		}
		
	}
	
	public bool ValidatePlayer(string playerId){
	
		return (playerScore.ContainsKey(playerId));
	}

	private void CreateTopScoreList(){
		
		int[] score = playerScore.Values.ToArray();
		Array.Sort(score);
		int lenght = score.Length-1;
	
		int loop = Math.Min(defaultTopList, lenght);
		topScorePlayers.Clear();
		for(int i =0 ; i<=loop; i++){
			int tempScore =  score[i];
			
			if(playerScore.ContainsValue(tempScore)){
				var playerId = playerScore.Keys.Where(x=> playerScore[x] == tempScore).FirstOrDefault();
				if(topScorePlayers.ContainsKey(playerId) != true)
					topScorePlayers.Add(playerId, tempScore);
				else
						topScorePlayers[playerId]= tempScore;
				
			}
		}
		
	}
}
interface IScoreManager
{
	/// <summary>

	/// Add a new player with initial score as zero

	/// </summary>

	/// <param name="playerId"></param>

	void AddNewPlayer(string playerId);



	/// <summary>

	/// Add 1 to the current score of player with Id = playerId

	/// </summary>

	/// <param name="playerId"></param>

	void IncrementPlayerScore(string playerId);



	/// <summary>

	/// Returns current scores of all the players

	/// </summary>

	/// <returns>Dictionary with keys as playerIds and values as their corresponding score</returns>

	Dictionary<string, int> GetAllPlayersScores();



	/// <summary>

	/// Returns top ten scorer players and their scores

	/// </summary>

	/// <returns>Dictionary with keys as playerIds and values as their corresponding score</returns>

	Dictionary<string, int> GetTopTenScorers();

}

// Define other methods, classes and namespaces here
