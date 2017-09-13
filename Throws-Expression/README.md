## Throw Expressions
> In C# previous version `throw` is an statement, so  can't used in lambda expression, conditional expression etc.. Now C# 7.0 `throw` is an expression, so can be used in lambda expression, expression bodied expression and conditional expression.

```c#
class Student
{
    private string _Name;
    public string Name
    {
        get => _Name;
        set => _Name = value ?? throw new ArgumentNullException(paramName : nameof(Name), message: $"{nameof(Name)} can not be null.");
    }
}
```