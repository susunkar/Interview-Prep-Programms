<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Net.Http.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Net.Http.WebRequest.dll</Reference>
  <Namespace>System.Net.Http</Namespace>
  <Namespace>System.Net.Http.Headers</Namespace>
  <Namespace>System.Security.Cryptography.X509Certificates</Namespace>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	Gateway();
}

void Gateway()
{
	WebRequestHandler handler = new WebRequestHandler();
	X509Certificate2 certificate;
	handler.ClientCertificateOptions = ClientCertificateOption.Manual;
	certificate = GetX509Certificate("f1b193652b1f434dda00c0a7aa8d3a6d160e675f");
	handler.ClientCertificates.Add(certificate);
	
	var client = new HttpClient(handler);
    var testData = ReadData("OrgLargeData.txt"); 
	client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
	client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "a8594380139d4a19a7db5a89ff208a53");

	var uri = "https://ecvlapigateway-uat.azure-api.net/organizationmanagementservicer1uat/api/Trade/AdhocDPLScreening";
	
	var message = new HttpRequestMessage
	{
		RequestUri = new Uri(uri),
		Method = HttpMethod.Post,
		Content = new StringContent(testData, Encoding.UTF8, "application/json")
	};
	HttpResponseMessage response = client.SendAsync(message).Result;

	response.StatusCode.Dump();
	response.Content.ReadAsStringAsync().Result.Dump();
}


string ReadData(string filename)
{
	string testdata = "";

	testdata= File.ReadAllText(@"C:\Users\susunkar\Desktop\" + filename);

	return testdata;
}

public X509Certificate2 GetX509Certificate(string certThumbprint)
{
	X509Certificate2 cert = null;
	X509Store store = new X509Store(StoreName.My, StoreLocation.LocalMachine);
	try
	{
		store.Open(OpenFlags.ReadOnly);
		var list = store.Certificates.Cast<X509Certificate2>().ToList();
		var clientCertificate = list.Find(c => c.Thumbprint != null && c.Thumbprint.Equals(certThumbprint, StringComparison.InvariantCultureIgnoreCase));//find the certificate by matching thumbprint
		cert = clientCertificate;
	}
	catch (Exception ex)
	{
		Console.WriteLine(ex);
	}
	finally
	{
		store.Close();
	}
	return cert;
}

