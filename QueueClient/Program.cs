using Azure.Storage.Queues;
using Azure.Storage.Queues.Models;

string queueName = "queue1";
string connectionString = "";
var queueClient = new QueueClient(connectionString, queueName);

Console.WriteLine("Press enter to peek messsages");
Console.ReadKey();
PeekedMessage[] messages = queueClient.PeekMessages(32);
foreach (var message in messages) Console.WriteLine(message.Body);

Console.WriteLine("Messages peeked successfully, deleting the queue...");
queueClient.Delete();

Console.ReadKey();