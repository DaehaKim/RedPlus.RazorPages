var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

var app = builder.Build();
app.UseStaticFiles(); // 정적인 HTML, CSS, JS 실행하고 싶다.

app.MapRazorPages();
app.MapGet("/", () => "Hello World!!!");

app.Run();
