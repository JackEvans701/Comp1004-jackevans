var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.UseRouting();

app.UseDefaultFiles();
app.UseStaticFiles();
app.Run();
