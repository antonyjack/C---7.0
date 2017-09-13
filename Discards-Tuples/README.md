## Discards

> `Discards` are temporary, write-only variables used in assignments when you don't care about the value assigned. `_` means "discard this parameter" if you declare it and use it.

```c#
//Method
(string, string, int, string) MultipleReturns()
{
    return ("James", "Raj", 30, "Male");
}
//Consume
//Retrive only required information skip other information usind discards
(string First, string Last, _, _) = MultipleReturns();
Console.WriteLine($"First name : {First}, Last name : {Last}");
```

> Discards are supported in the following scenarios:
1. When deconstructing tuples or user-defined types.
2. When calling methods with `out` parameters.
3. In a pattern matching operation with the `is` and `switch` statements.
4. As a standalone identifier when you want to explicitly identify the value of an assignment as a discard.
