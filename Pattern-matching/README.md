## Pattern Matching

>`Pattern matching` is a feature that allows you to implement method dispatch on properties other than the type of an object.

> Pattern matching supports `is` expressions and `switch` expressions. Each enables inspecting an object and its properties to determine if that object satisfies the sought pattern. You use the `when` keyword to specify additional rules to the pattern.

### `is` Expressions
> `is` operator is used to query an object beyond its type.
```c#
//const value matching pattern
object a = 10;            
if(a is string val)
    WriteLine($"string : {val}");
else if(a is decimal val1)
    WriteLine($"decimal : {val1}");
else if(a is int val2)
    WriteLine($"integer : {val2}");
else
    WriteLine("Invalid datatype");  
```

### `switch` Statement
>You can switch on any type (not just primitive types). Patterns can be used in case clauses
```c#
//Switch case pattern matching, Primitive data types
object b = "James";
switch (b)
{
    case int i:
        WriteLine($"integer : {i}");
        break;
    case string j:
        WriteLine($"string : {j}");
        break;
    case float k:
        WriteLine($"float : {k}");
        break;                
    default:
        WriteLine("Invalid datatype");
        break;
}

//Method
void Matching(object e)
{
    //switch patter matching for class object and enumerable objects
    switch (e)
    {
        case Student s:
            WriteLine($"Name of the student is :{s.LastName}, {s.FirstName}");
            break;
        case Person p:
            WriteLine($"Name of the person is : {p.LastName}, {p.FirstName}");
            break;                
        case null:
            WriteLine("Null object");
            break; 
        case List<int> m when m.Any():
            WriteLine($"Length of the List object is : {m.Count}");
            break;
        default:
            WriteLine("Invalid object");
            break;
    }
}

//Consume
Matching(new Student()
{
    FirstName = "Antony",
    LastName = "Samy"
});

Matching(new Person(){
    FirstName = "James",
    LastName = "Raj"
});

Matching(null);

Matching(new List<int>());

Matching(new List<int>(){10,20});
```