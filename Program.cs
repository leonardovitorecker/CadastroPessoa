using Microsoft.EntityFrameworkCore;
using PessoaCadastro.database;
using PessoaCadastro.Repoitorios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Context>(
    options => options.UseNpgsql("Host=localhost;Port=5432;Database=pessoas1;User Id=postgres; Password=postgres;"));
builder.Services.AddTransient <IPessoaRepositorio,PessoaRepositorio>();
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Pessoas}/{action=Cadastro}/{id?}");

app.Run();
