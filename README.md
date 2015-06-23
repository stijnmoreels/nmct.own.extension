# nmct.own.extension
Extension Methods


Usage:

## 1. Add "CsvAttribute" to the properties you want to export
Example Class Person
```
public class Person
{
  [CsvAttribute]
  public string Name { get; set; }
  [CsvAttribute]
  public int Phone { get; set; }

  public string DontExport { get; set; }
}
```

## 2. Add namespace "CsvExtension" to your file
```
using CsvExtension;
```

## 3. Export from any list
```
 List<Person> persons = new List<Person>();
 string personCSV = persons.ToCsv<Person>();
```

Done !!!
