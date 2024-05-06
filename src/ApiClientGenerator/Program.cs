using Jago.Generator;

System.Console.WriteLine(">>> Begin");

var httpClient = new HttpClient();

var client = new Client(httpClient);

var response = await client.GetStatusAsync();

System.Console.WriteLine($">>> {response.Status}");

System.Console.WriteLine(">>> End");