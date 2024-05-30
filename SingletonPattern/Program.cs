using SingletonPattern;

Console.WriteLine($"Counter: {Singleton.Instance.Counter}");

Singleton.Instance.Counter++;
Console.WriteLine($"Counter: {Singleton.Instance.Counter}");

Singleton.Instance.Counter++;
Console.WriteLine($"Counter: {Singleton.Instance.Counter}");


// Instantiating a new Singleton i.e. new Singleton(); 
// Throws: 'Singleton.Singleton()' is inaccessible due to its protection levelCS0122