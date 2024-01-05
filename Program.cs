using BlazorRenderTest;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapBlazorHub();

app.UseStaticFiles();
app.UseRouting();
app.MapDefaultControllerRoute();
app.MapFallbackToPage("/_Host");

app.Run();