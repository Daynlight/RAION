var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/", () =>{
  return "Hello Controller";
})
.WithName("Controller");

app.Run();

