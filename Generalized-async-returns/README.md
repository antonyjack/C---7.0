## Generalized Async Return

### ValueTask<T>
> A simple optimization would be to use `ValueTask` in places where `Task` would be used before. However, if you
want to perform extra optimizations by hand, you can cache results from `async` work and reuse the result in
subsequent calls. The `ValueTask` struct has a constructor with a `Task` parameter so that you can construct a
`ValueTask` from the return value of any existing async method.

> Note: You need to add the NuGet package `System.Threading.Tasks.Extensions` in order to use the `ValueTask<TResult>` type.

```c#
public class Student
{
    List<string> Students = new List<string>();

    public ValueTask<bool> AddStudent(string name) => new ValueTask<bool>(Add(name));

    async Task<bool> Add(string name)
    {                 
        Students.Add(name);
        return true;
    }

    public List<string> GetStudents() => Students.Any() ? Students : new List<string>();
}
```
