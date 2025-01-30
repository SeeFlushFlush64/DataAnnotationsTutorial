using AnnotationsTutorial.EntityClasses;
using AnnotationsTutorial.ValidationClasses;
using System.ComponentModel.DataAnnotations;



Product entity = new()
{
    ProductID = 1,
    Name = "",
    ProductNumber = "",
    Color = "",
    StandardCost = 0,
    ListPrice = 0,
    SellStartDate = Convert.ToDateTime("01/01/2022"),
    SellEndDate = Convert.ToDateTime("31/12/2022"),
    DiscontinuedDate = DateTime.Now
};
//List<ValidationResult> msgs;
//msgs = ValidationHelper.Validate(entity);

//if (msgs.Count > 0)
//{
//    foreach (var item in msgs)
//    {
//        Console.WriteLine(item);
//    }
//    Console.WriteLine();
//    Console.WriteLine($"Total Validations Failed: {msgs.Count}");
//}
//else
//{
//    Console.WriteLine("Entity is valid");
//}
List<ValidationMessage> customValidation = ValidationHelper.ValidateToValidationMessage(entity);
if (customValidation.Count > 0)
{
    foreach (ValidationMessage item in customValidation)
    {
        Console.WriteLine(item.ToString());
    }
    Console.WriteLine();
    Console.WriteLine($"Total Validations Failed: {customValidation.Count}");
}
else
{
    Console.WriteLine("Entity is valid");
}