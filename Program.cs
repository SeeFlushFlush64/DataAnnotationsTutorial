using AnnotationsTutorial.EntityClasses;
using AnnotationsTutorial.ValidationClasses;
using System.ComponentModel.DataAnnotations;

List<ValidationResult> msgs;

Product entity = new()
{
    ProductID = 1,
    Name = " ",
    ProductNumber = "",
    Color = "",
    StandardCost = 0,
    ListPrice = 0,
    SellStartDate = Convert.ToDateTime("01/01/2022"),
    SellEndDate = Convert.ToDateTime("31/12/2022"),
    DiscontinuedDate = DateTime.Now
};

msgs = ValidationHelper.Validate(entity);

if (msgs.Count > 0)
{
    foreach (var item in msgs)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine();
    Console.WriteLine($"Total Validations Failed: {msgs.Count}");
}
else
{
    Console.WriteLine("Entity is valid");
}