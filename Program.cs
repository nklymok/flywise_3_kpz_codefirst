using FlyWiseBackend.Data;

using DbFlyWiseContext context = new DbFlyWiseContext();

context.Airplanes.Add(new FlyWiseBackend.Models.Airplane()
{
    Name = "Boeing 737"
});
context.SaveChanges();