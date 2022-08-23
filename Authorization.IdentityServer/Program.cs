using Authorization.IdentityServer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddIdentityServer()
    .AddInMemoryApiResources(Configuration.GetApiResources())
    .AddInMemoryClients(Configuration.GetClients())
    .AddInMemoryIdentityResources(Configuration.GetIdentityResources())
    .AddDeveloperSigningCredential();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseIdentityServer();

app.MapControllers();

app.Run();
