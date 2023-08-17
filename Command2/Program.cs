using Command2;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;

var _repo = new LivroRepositorioCsv();
Author[] authors = new Author[2];
authors[0] = new Author("Owen King", "owenking@hotmail.com", 'M');
authors[1] = new Author("Stephen King", "stephking64@shining.com", 'M');
_repo.Add(new Book("Belas Adormecidas", authors, 45.00, 3));
_repo.PrintCsvContents();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
