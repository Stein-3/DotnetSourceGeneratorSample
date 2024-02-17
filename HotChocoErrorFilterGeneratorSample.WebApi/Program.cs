using HotChocoErrorFilterGeneratorSample.WebApi;
using HotChocoErrorFilterGeneratorSample.WebApi.Query;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddErrorFilter<ErrorFilter>();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGraphQL();

app.Run();
