using CompanyEmployees.Extensions;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc.ApplicationParts;


var builder = WebApplication.CreateBuilder(args);

// Adding the services we to the container

builder.Services.ConfigureCors();
builder.Services.ConfiureISSIntegration();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline


if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();
else
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();


app.UseForwardedHeaders(new ForwardedHeadersOptions()
{
    ForwardedHeaders = ForwardedHeaders.All
});

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();