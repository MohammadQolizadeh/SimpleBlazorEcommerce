global using BlazorEcommerce.Shared;
global using Microsoft.EntityFrameworkCore;
global using  BlazorEcommerce.Server.Data;
using BlazorEcommerce.Server.Services.ProductService;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

#region DbContext
builder.Services.AddDbContext<DataContext>(opttions =>
{
    opttions.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

#endregion



builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

#region Swagger

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#endregion


#region ServiceRegister

builder.Services.AddScoped<IProductService,ProductService>();

#endregion


var app = builder.Build();

#region SwaggerMiddelWare

app.UseSwaggerUI();

#endregion

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSwagger();

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
