## Local Function

> In C# 7.0 we can create nested function inside function.

```c#
static void Main(string[] args)
{
    void Internal() => 
        Console.WriteLine("Hello World!");
    Internal();
}
```