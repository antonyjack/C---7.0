## `out` variables improvement

> In c# previous version `out` variable must be declared before we passed as parameter.

```c#
int num;
if(int.TryParse(Number, out num)) // Old way use out parameter, variable must be declare before use.
{
    WriteLine("C# Old Version :" + num);
}
else
{
    WriteLine("Invalid integer");
}
```

> C# 7.0 improve, we can declare `out` keyword inside method argument list.

```c#
if(int.TryParse(Number, out int newNum)) //C# 7.0 we can declare variable inside parameter 
{
    WriteLine("C# 7.0 out feature: " + newNum);
}
else
{
    WriteLine("Invalid integer");
}
```