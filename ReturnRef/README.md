## Ref locals and returns

> You can pass things by reference (with the ref modifier) in C#, you can now return them by reference, and also store them by reference in local variables.

```c#
//ref return method
ref string GetName(int index, string[] names) 
{
    return ref names[index];
}
//normal method
static string GetName(int index, string[] names) 
{
    return names[index];
} 
```

> Above `ref` return method is return reference of the variable. If you modified the retrived object, array also modified because the array element and variable share the same location in memory.
Normal method return as value, so if you modify the value it will not affect array element. Because both are using different location.

```c#
string[] Names = {"james","raj","adrews","aravinda"};
```

```c#
ref string Name = ref GetName(1, Names);
Name = "Divya";
```
> The above code, `GetName(1, Names)` method return `raj` as reference type, next line the reference modified from `raj` to `Divya`. Not check the array elements, it was modified because the modification of second line. Because both where shared same location.

```c#
string Name = GetName(1, Names);            
Name = "Arun";
```
> The above code, `GetName(1, Names)` method return `raj` as value type, so the next line modification affect in local `Name` variable not in array element.