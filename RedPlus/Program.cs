var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

var app = builder.Build();
app.UseStaticFiles(); // ������ HTML, CSS, JS �����ϰ� �ʹ�.

app.MapRazorPages();
app.MapGet("/", () => "Hello World!!!");

app.Run();
