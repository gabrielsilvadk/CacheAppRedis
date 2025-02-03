using StackExchange.Redis;

string connectionString = "";

using (var cache = ConnectionMultiplexer.Connect(connectionString))
{
    IDatabase db = cache.GetDatabase();

    var result = await db.ExecuteAsync("PING");
    Console.WriteLine(result);

    bool setValue = await db.StringSetAsync("name", "DIO gsilva");
    Console.WriteLine(setValue);
    
    string getValue = await db.StringGetAsync("name");
    Console.WriteLine(getValue);
}