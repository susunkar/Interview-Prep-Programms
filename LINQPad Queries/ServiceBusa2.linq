<Query Kind="Program">
  <NuGetReference>Microsoft.Azure.ServiceBus</NuGetReference>
  <NuGetReference>Rock.Core.Newtonsoft</NuGetReference>
  <Namespace>Microsoft.Azure.ServiceBus</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>Newtonsoft.Json.Linq</Namespace>
  <Namespace>Newtonsoft.Json</Namespace>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

class Program
	{
		const string ServiceBusConnectionString = "Endpoint=sb://bedrocklicensinggeneventa2.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=7YqaxxMRbHJI5vluq4+Mfcr04QIPLVlLRlWx36/WZV0=";
		const string TopicName = "ordering";
		static ITopicClient topicClient;

		static void Main(string[] args)
		{
			MainAsync().GetAwaiter().GetResult();
		}

		static async Task MainAsync()
		{
			topicClient = new TopicClient(ServiceBusConnectionString, TopicName);
			// Send messages.
			
			await SendMessagesAsync();
			await topicClient.CloseAsync();
		}

		static async Task SendMessagesAsync()
	{
		try
		{
			// Create a new message to send to the topic
			var messageBody = @"{" + "\"EventID\":null,\"EventCorrelationID\":\"7bf44d04-76cf-42f0-82e3-913f677356b2\",\"EventCategoryCode\":\"INV\",\"EventStatusCode\":\"RDY\",\"EventTypeCode\":\"PTO\",\"SourceSystem\":\"PTO\",\"RetryTenants\":null,\"ProgramCode\":null,\"CustomFields\":{\"BlobIdentifier\":\"ParallelTest-7bf44d04-76cf-42f0-82e3-913f677356b2\"},\"EventInformation\":null,\"Information\":null,\"BrokeredMessageId\":null}";
					JObject msg = JObject.Parse(messageBody);  
					var message = new Message(Encoding.UTF8.GetBytes(messageBody));

					// Write the body of the message to the console
					Console.WriteLine($"Sending message: {messageBody}");

					// Send the message to the topic
					await topicClient.SendAsync(message);
				
			}
			catch (Exception exception)
		{
			Console.WriteLine($"{DateTime.Now} :: Exception: {exception.Message}");
		}
	}
}
