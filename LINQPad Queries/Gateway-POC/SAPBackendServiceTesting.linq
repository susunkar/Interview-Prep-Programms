<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Net.Http.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Web.Extensions.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Web.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Web.Services.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Data.Services.Design.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Configuration.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.ServiceModel.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Design.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Web.ApplicationServices.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.ServiceModel.Activation.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Data.Services.Client.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Data.Entity.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Windows.Forms.dll</Reference>
  <NuGetReference>Rock.Core.Newtonsoft</NuGetReference>
  <Namespace>System.Net.Http</Namespace>
  <Namespace>System.Net.Http.Headers</Namespace>
  <Namespace>Newtonsoft.Json.Linq</Namespace>
  <Namespace>Newtonsoft.Json</Namespace>
  <Namespace>System.Web.Script.Serialization</Namespace>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

void Main()
{
	//Gateway();
	SAPBackEnd();
}
void Gateway(){
	var client = new HttpClient();

	client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); 
    client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "26495ceb001246c6bff393c82ba4eb54");
   
	var uri = "https://ecvlapigateway-dev.azure-api.net/SAPServiceMSG/invoicestatus?invoicenumbers=9989000050";
	HttpResponseMessage response = client.GetAsync(uri).Result;
	
	response.StatusCode.Dump();
	response.Content.ReadAsStringAsync().Result.Dump();
}
void SAPBackEnd(){
	var client = new HttpClient();

	client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); 
	
    client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "c55ddee3fc0643eab5534af29776892c");
    client.DefaultRequestHeaders.Add("X-CorrelationId", "fb48a0e3-3302-45c1-bcb0-a82f5b4c4cc7");
	//client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6IndVTG1ZZnNxZFF1V3RWXy1oeFZ0REpKWk00USIsImtpZCI6IndVTG1ZZnNxZFF1V3RWXy1oeFZ0REpKWk00USJ9.eyJhdWQiOiJodHRwczovL3RTQVBXU0FBREFwcCIsImlzcyI6Imh0dHBzOi8vc3RzLndpbmRvd3MubmV0LzcyZjk4OGJmLTg2ZjEtNDFhZi05MWFiLTJkN2NkMDExZGI0Ny8iLCJpYXQiOjE1NDQxNzk0MTcsIm5iZiI6MTU0NDE3OTQxNywiZXhwIjoxNTQ0MTgzMzE3LCJhaW8iOiI0MlJnWUNqZ1lqNGFraFUxOFcrSlo2bUo5U1FsQUE9PSIsImFwcGlkIjoiMjY1ZGVhMTUtOTlkYy00NGI0LTllODktZGM2ZWVhMGIxOGJmIiwiYXBwaWRhY3IiOiIxIiwiaWRwIjoiaHR0cHM6Ly9zdHMud2luZG93cy5uZXQvNzJmOTg4YmYtODZmMS00MWFmLTkxYWItMmQ3Y2QwMTFkYjQ3LyIsIm9pZCI6IjQzMWYzMmJmLTE1NmItNDU0Zi1hZDI1LTZkMWM5ODJhNzVkZCIsInN1YiI6IjQzMWYzMmJmLTE1NmItNDU0Zi1hZDI1LTZkMWM5ODJhNzVkZCIsInRpZCI6IjcyZjk4OGJmLTg2ZjEtNDFhZi05MWFiLTJkN2NkMDExZGI0NyIsInV0aSI6IkwwSGlnMjlvWlVpbUtkVWZVOVNiQUEiLCJ2ZXIiOiIxLjAifQ.mHvF-_2YnXuV2ZwjoJsPJArPKvpltjktaQdcH-hOjBOnP1p2GUZj574o6bsvU70aZNbNEkW_9goc9nWnQh_HzsDPm2ZOanpM1pPgEqev1zN4q_abrO9sEp0rk2-0OmipvtCGmsHIhoSQMuFl2MGVSSPe_l-jIMOxtGTRZGRuAhN6zVm3AjtclnzvXtWOA8Xu7z4DhhNzHst174mXr7TZeQshO2qM0Ys-yt9rLamuheNA55bMecKim9fiVVjemPK2lFSByR-qEmyR-Aw3w8Sd0SoySq-332hW5RSABub5Khi_7QQ-ufbdtcUL8swuI8te22uoMVDQakESDoi6Dz_PcQ");
	client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6IndVTG1ZZnNxZFF1V3RWXy1oeFZ0REpKWk00USIsImtpZCI6IndVTG1ZZnNxZFF1V3RWXy1oeFZ0REpKWk00USJ9.eyJhdWQiOiJodHRwczovL3RTQVBXU0FBREFwcCIsImlzcyI6Imh0dHBzOi8vc3RzLndpbmRvd3MubmV0LzcyZjk4OGJmLTg2ZjEtNDFhZi05MWFiLTJkN2NkMDExZGI0Ny8iLCJpYXQiOjE1NDQ1MDQ0NjYsIm5iZiI6MTU0NDUwNDQ2NiwiZXhwIjoxNTQ0NTA4MzY2LCJhaW8iOiI0MlJnWURBV0VwZXJURmZaY2xsUGo1VTVMK0lnQUE9PSIsImFwcGlkIjoiMjY1ZGVhMTUtOTlkYy00NGI0LTllODktZGM2ZWVhMGIxOGJmIiwiYXBwaWRhY3IiOiIxIiwiaWRwIjoiaHR0cHM6Ly9zdHMud2luZG93cy5uZXQvNzJmOTg4YmYtODZmMS00MWFmLTkxYWItMmQ3Y2QwMTFkYjQ3LyIsIm9pZCI6IjQzMWYzMmJmLTE1NmItNDU0Zi1hZDI1LTZkMWM5ODJhNzVkZCIsInN1YiI6IjQzMWYzMmJmLTE1NmItNDU0Zi1hZDI1LTZkMWM5ODJhNzVkZCIsInRpZCI6IjcyZjk4OGJmLTg2ZjEtNDFhZi05MWFiLTJkN2NkMDExZGI0NyIsInV0aSI6IkN4UzhKbEIxdlVpbXJLUy1NbHNNQUEiLCJ2ZXIiOiIxLjAifQ.XQLtSggl8BmG5mXEd7WCJ2z0a7lDqYSqL-ijuSv3rUGAQrbWeO9zk6RTz4gvMQwI5SC1SQlB-3THpnoWLBGMia79AXba0QVUI2aYwVCkbKdQ_FQFQhQqeNna2Oak6c2-OOqO52tXfCpvYAqZa0wtAVBzm-7fT7SZ-orPVf_5UmcwRytyKSgipcVX9dEKKWfunUdDZsmx9HyG7bf0_WS03vtjpbr7XtK6CyrmtPfO1KQ2W-6YFHpYnZtgdleLxdy9HI6j7lSFMDQC7mZQzkkVUJnJLR9XmCSHkyNxG6U7w8s4CzAGXZRbr0mWZ7JvgnmAQFAOjnbd0FmMuJ9Fg1zixw");

	var uri = "https://saptstws.trafficmanager.net/MSG/MSFinancePOCreation/api/PurchaseOrders/UpdateInBillingDocument";
	
	//string postBody = "{\"INPUT\": [{\"VBELN\": \"9989000020\"},{\"VBELN\": \"9989000050\"}],\"UUID_CONFIRMATION\": \"X\"}";
	string postBody = "{\r\n  \"INPUT\": [\r\n    {\r\n      \"VBELN\": \"9826436710\"\r\n    }, {\r\n      \"VBELN\": \"9989000010\"\r\n    },\r\n    {\r\n      \"VBELN\": \"9989000050\"\r\n    },\r\n    {\r\n      \"VBELN\": \"9989000051\"\r\n    },\r\n    {\r\n      \"VBELN\": \"9989000018\"\r\n    },\r\n    {\r\n      \"VBELN\": \"9989000020\"\r\n    }\r\n  ],\r\n  \"UUID_CONFIRMATION\": \"\"\r\n}";

    HttpResponseMessage wcfResponse = client.PostAsync(uri, new StringContent(postBody, Encoding.UTF8, "application/json")).Result; 

	var res = wcfResponse.Content.ReadAsStringAsync().Result;
	res.Dump();
	
	JObject o = JObject.Parse(res);
	JArray array = (JArray)o["OUT"];
	
	var jbody = new JObject();
	var jInvoice = new JArray();
	
	foreach (var a in array)
	{
		var MSG_NUMBER =(int) a["MSG_NUMBER"];
		var VBELN = a["VBELN"];
		var eReceipt = "NA";
		
		if(MSG_NUMBER == 7)
		{
			eReceipt = "true";
		}
		if(MSG_NUMBER == 8)
		{
			eReceipt = "false";
		}
		jInvoice.Add( new JObject( new JProperty("invoiceNumber",VBELN),new JProperty("eReceiptStatus",eReceipt)));
      				
	}
	jInvoice.ToString().Dump();
}