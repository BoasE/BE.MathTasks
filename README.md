# BE.MathTasks
Library for creating mathematical training tasks like arithmetic tasks

##TimesTables 1-10
All math tasks are annotated. e.g. core task
```csharp
 var tables = new SmallTimesTable();
 var tasks = tables.AllForTable(3); // All Tasks for the 3rd Times table
 
 tasks = tables.RandomTasks(MultiplicationTaskRequest.ForTable(3), 4); //4 non duplicte tasks of the 3rd timestable
 
 
 ```
