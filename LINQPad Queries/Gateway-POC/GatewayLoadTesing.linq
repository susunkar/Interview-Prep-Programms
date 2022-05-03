<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Net.Http.dll</Reference>
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Net.Http</Namespace>
  <Namespace>System.Net.Http.Headers</Namespace>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	Task[] tasks = new Task[3];
	tasks[0] = Task.Run(() =>
	{
		Thread.Sleep(1000);
		Console.WriteLine('1');
		Gateway();
		return 1;
	});
	tasks[1] = Task.Run(() =>
	{
		Thread.Sleep(2000);
		Console.WriteLine('2');
		Gateway();
		return 2;
	});
	tasks[2] = Task.Run(() =>
	{
		Thread.Sleep(1000);
		Console.WriteLine('3');
		Gateway();
		return 3;
	}
	);
	Task.WaitAll(tasks);
	
}
void Gateway()
{
	var client = new HttpClient();

	client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
	client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "612d0bae6b1f4bdf8f1e814aa8bbdb51");

	var uri = "https://ecvlapigateway-dev.azure-api.net/confirmationservicer1uat/api/Confirmation/ping";
	HttpResponseMessage response = client.GetAsync(uri).Result;

	response.StatusCode.Dump();
	response.Content.ReadAsStringAsync().Result.Dump();
}

// Define other methods and classes here
