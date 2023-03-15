HttpClient client = new();

var res =  await client.GetAsync("https://www.youtube.com/watch?v=lLWEXRAnQd0");

Console.WriteLine(res.Content.Headers);