var builder = DistributedApplication.CreateBuilder(args);

var postgres = builder.AddPostgres("postgres");
var postgresdb = postgres.AddDatabase("postgresdb", "monkey");

builder.AddProject<Projects.Monkey_WebApi>("monkey-webapi")
    .WithExternalHttpEndpoints()
    .WithReference(postgresdb);

builder.Build().Run();


//var cache = builder.AddRedis("cache");

// var apiService = builder.AddProject<Projects.Monkey_ApiService>("apiservice");

/*
builder.AddProject<Projects.Monkey_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(cache)
    .WithReference(apiService);


var webApi = builder.AddProject<Projects.Monkey_WebApi>("webApi");

builder.Configuration
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddUserSecrets("954f88c5-7b57-4ee7-8cc0-3b68a3af728e");
builder.Services.Configure<AspireConfiguration>(builder.Configuration.GetSection(AspireConfiguration.Section));
var configuration = builder.Configuration.GetSection(AspireConfiguration.Section);

var postresUserName = configuration.GetSection(nameof(AspireConfiguration.PostgresUserName)).Value ?? String.Empty;
var postresPassword = configuration.GetSection(nameof(AspireConfiguration.PostgresPassword)).Value ?? String.Empty;
var username = builder.AddParameter("username", secret: true);
var password = builder.AddParameter("password", secret: true);
var postgres = builder.AddPostgres("postgres", username, password);
var postgresdb = builder.AddPostgres("postgres", username, password).AddDatabase("postgresdb", "monkey");
*/

