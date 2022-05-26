# TP .Net Week 2 Part 1

This project is an example of using  Extension Methods, Attribute Usage and Solid Principles Usage.

### What I have used so far:
- Asp.Net Core Web API with `.Net6.0` framework.
- To test the APIs, *Swagger* and *Postman* has been used.
- Also the outputs printed in the Console.

## Requirements
- Calculating the difference between given DateTime and current DateTime.
- Creating CustomAttributes which can give Class Name and Field Properties.
- Creating an Example by using Solid Principles such as Depencency Inversion and Interface Segragation 

## Installation and Usage

To get the project :
```
    git clone https://github.com/186-Teleperformans-Net-Bootcamp/hafta2-1-mhtaldmr.git
```
To reach the project folder :
```
    cd hafta2-1-mhtaldmr 
    cd MuhammetAliDemir.TP.Net.Hw2.Part1
```
To run the project:
- If you are using the Visual Studio, just press **F5** or press **Start Debugging**.

- If you are using terminal : 
```
    dotnet run
```
- The port will be listening on : https://localhost:8001

<br>
*  Examples of endpoints like:
<img src="https://github.com/186-Teleperformans-Net-Bootcamp/hafta2-1-mhtaldmr/blob/main/endpoints.PNG" alt="endpoint" />

- **Usage  of Attributes**
    -  It will just return of the table informations.
- **Usage  of DateTime**
    -  You need to enter a valid Date like:   ***DD/MM/YYYY  HH:MM:SS***
- **Usage  of Coffee Interface**
    -  It will just return of the Sweet Coffee recipe informations.
    - For Bitter recipe you need to change implementation on Program.cs
 

## Implementations
 **1. Extension Example**
    - Creating an Extension by using DateTime object in .Net
    - The main point here to create Static class and method. Also using this keyword.
```c
    public static class DateTimeExtension
    {
        public static string AgoOrAfter(this DateTime date)
        {
        ...
        return "string";
        }
    }
```

*   **2. Attributes Example**
    - To generate a table and column fields two Attributes generated.

TableIdentifier Attribute
```c
    [AttributeUsage(AttributeTargets.Class)]
    public class TableIdentifierAttribute : Attribute
    {
        public string Name { get; set; }

        public TableIdentifierAttribute(string name)
        {
            Name = name;
        }
    }
```
Using the Attributes
```c
    [TableIdentifier("Student")]
    public class Student
    {
        [ColumnIdentifier("Id", "int", isRequired: true)]
        public int Id { get; set; }
        [ColumnIdentifier("Name", "string", isRequired: false)]
        public string Name { get; set; }
    }
```


- **3. Solid Principles Example**
    - For using Interfaces a )CoffeeMaker interface is generated
    - A new IWhiteChocoCoffeeMaker Interface generated and ICoffeeMaker inherited for Interface Segradation.
    - Also this interface injected to Controller Constructor.
```c
    private readonly IWhiteChocoCoffeeMaker _whiteChocoCoffeeMaker;

    public CoffeesController(IWhiteChocoCoffeeMaker whiteChocoCoffeeMaker)
    {
        _whiteChocoCoffeeMaker = whiteChocoCoffeeMaker;
    }
```
-   - Two Different implementation has been made for IWhiteChocoCoffeeMaker added.
    - BitterWhiteChoco and WhiteChoco added and it has registered in Program.cs
    - By using this, Whenever we want we can change implementation into Bitter or Sweet Coffee.
```c
    builder.Services.AddScoped<IWhiteChocoCoffeeMaker, BitterWhiteChocoMaker>();
    //builder.Services.AddScoped<IWhiteChocoCoffeeMaker, SweetWhiteChocoMaker>();
```

---
