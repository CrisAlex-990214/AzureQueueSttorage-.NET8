using Azure.Storage.Queues;

string queueName = "queue1";
string connectionString = "";
var queueClient = new QueueClient(connectionString, queueName);

Console.WriteLine("Creating queue...");
queueClient.Create();

Console.WriteLine("Press Enter to Send Messages");
Console.ReadKey();
for (int i = 1; i <= 32; i++) queueClient.SendMessage($"Message #{i}");
Console.WriteLine("Messages sent successfully!");

Console.ReadKey();