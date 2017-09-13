## Expression Bodied Members
> C# 6 introduced `expression-bodied members` for member functions, and read-only properties. C# 7 expands the allowed members that can be implemented as expressions. In C# 7, you can implement `constructors`, `finalizers`, and `get` and `set` accessors on `properties` and `indexers`

```c#
 public class Student
{
    //Expression bodied constructor
    public Student() => Console.WriteLine("Expression bodied constructor working fine.");
    
    //Expression bodied distructor
    ~Student() => Console.WriteLine("Expression bodied distructor working fine.");

    //Expression bodied property
    private string _Name;
    public string Name
    {
        get => _Name;
        set => _Name = value ?? "Default";
    }

    public void Display() => Console.WriteLine($"Welcome {this.Name}");                
}
```