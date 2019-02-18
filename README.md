# parent2heir

For extend of model

```c#
public class SomeExternalModel{
    public string FirstName {get;set;}
    public string LastName {get;set;}
}

```

## classic

```c#
public class SomeExternalModelExt:{
    public SomeExternalModel Model {get;set;}
    public SomeExternalModelExt(SomeExternalModel model){
        Model = model;
    }
        public bool IsValid => 
        //I wan't write it `Model.`
        !string.IsNullOrEmpty(Model.FirstName) &&  
          !string.IsNullOrEmpty(Model.LastName)
}
//or
public class SomeExternalModelExt:SomeExternalModel{
     public SomeExternalModelExt(SomeExternalModel model){
        //I don't like it
        FirstName = model.FirstName;
        LastName = model.LastName;
    }
    public bool IsValid => !string.IsNullOrEmpty(FirstName) &&  
                            !string.IsNullOrEmpty(LastName)
}

```

## Solution

```c#
//now model
public class SomeExternalModelExt:SomeExternalModel{
    public bool IsValid => !string.IsNullOrEmpty(FirstName) &&  
                            !string.IsNullOrEmpty(LastName)
}
```

```c#
//example
SomeExternalModel model = someApiService.GetSomeModel("some parameter");
//action 
var modelExt = model.ToHeir<SomeExternalModel, SomeExternalModelExt>();
if(modelExt.IsValid)
    ...
```