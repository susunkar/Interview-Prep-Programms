<Query Kind="Program">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	CarTasks Paint = new CarTasks("Painting", new List<CarTasks>());
	CarTasks Chassis = new CarTasks("Car Chassis Build", new List<CarTasks>());
	CarTasks BuildCar = new CarTasks("BuildCar", new List<CarTasks>());
	CarTasks Doors = new CarTasks("Doors placed", new List<CarTasks>() {
		 Chassis
	});

	CarTasks Windows = new CarTasks("Windows setup", new List<CarTasks>() {
		 Chassis,
		 Doors
	});

	CarTasks Eng = new CarTasks("Car Engine placed", new List<CarTasks>() {
		 Windows,
		 Paint
	});

	CarTasks FuilFilling = new CarTasks("Fuel car tank ", new List<CarTasks>() {
		 Eng,
		 BuildCar
	});

	CarTasks StartCar = new CarTasks("StartCar", new List<CarTasks>() {
		 FuilFilling
	});

	CarTasks RunCar = new CarTasks("RunCar", new List<CarTasks>() {
		 StartCar
	});
	
	RunCar.Execute();
	
}

public class CarTasks
{
	private string taskid ;
	private List<CarTasks> depedencyTakList;
	private bool TaskDone = false;
	
	public CarTasks(string id, List<CarTasks> depedentTasks){
		this.taskid = id;
		depedencyTakList = new List<UserQuery.CarTasks>();
		depedencyTakList.AddRange(depedentTasks);
	}
	
	public void Execute(){
		if(TaskDone)
			return;
		
		foreach (var task in depedencyTakList)
		{
			task.Execute();
		}
		RunTask();
	}

	private void RunTask()
	{
		TaskDone = true;
		Console.WriteLine("Complted Task id {0}", taskid);
	}
}
// Define other methods and classes here
