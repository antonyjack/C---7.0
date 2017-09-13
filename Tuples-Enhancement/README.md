## Tuples Enhancement

> Tuples were available before C# 7, but they were inefficient and had no language support. This meant that tuple elements
could only be referenced as `Item1` , `Item2` and so on. C# 7 introduces language support for tuples, which enables `semantic
names` for the fields of a tuple using new, more efficient tuple types.

```c#
//semantic named tuples
(string Name, int Age) = ("James", 30);
WriteLine($"Name is : {Name}");
WriteLine($"Age is : {Age}");
```

> You can also specified names of the field inside tuple.
```c#
//Named tuples
var NamesValues = (Name:"Andrews", Age:32);
WriteLine($"Name is : {NamesValues.Name}");
WriteLine($"Age is : {NamesValues.Age}");
```

> You can specify the name fields both side should be same, otherwise it throws an error.
```c#
(string Name, string Gender) = (First: "Aravinda", Second:"Male");
```
> Above line throws an error, `CS8123` names conflict in left side.

### Deconstruct 
> `Deconstruct` method as a member of the `class`. That `Deconstruct` method provides a set of `out` arguments for each of the properties you want to extract.

```c#
public class Example
{
    public Example(int num1, int num2)
    {
        Num1 = num1;
        Num2 = num2;
    }
    public int Num1 {get;}
    public int Num2{get;}

    public void Deconstruct(out int num1, out int num2, out string message)
    {
        num1 = this.Num1;
        num2 = this.Num2;
        message = "Deconstruct method implemented";
    }
}
```
> You can extract the individual fields by assigning a tuple to an object.
```c#
var E = new Example(2,22);
(int One, int Two, string Message) = E;
WriteLine(Message);
```
> C# 7.0 brings tuple types and tuple literals for you it just return multiple values/ multiple type inform of tuple object

```c#
public class Example
{
    public Example(int num1, int num2)
    {
        Num1 = num1;
        Num2 = num2;
    }
    public int Num1 {get;}
    public int Num2{get;}

    public (int, int) GroupFunction()
    {
        int add = this.Num1 + this.Num2;
        int mul = this.Num1 * this.Num2;
        return(add, mul);
    }
}
//Consume
var E = new Example(2,22);

(int add, int mul) = E.GroupFunction();
WriteLine($"Addition : {add}");
WriteLine($"Multiplication : {mul}");
```