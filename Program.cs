using syncfusionTest.Components;
using Microsoft.EntityFrameworkCore;
using syncfusionTest.Data;
using Syncfusion.Blazor;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<TdmsDataContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddSyncfusionBlazor();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

var app = builder.Build();
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBMAY9C3t2UVhhQlVFfV5dX2NWfFN0QXNRdVp0flRFcDwsT3RfQF5iS3xRdkRjX3xbcHBdRg=="); //라이센스 추가
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
