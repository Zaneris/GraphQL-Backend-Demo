using Microsoft.EntityFrameworkCore;
using Users;
using Users.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddCors()
    .AddDbContext<DataContext>(o => o.UseSqlite("Data Source=data.db"))
    .AddGraphQLServer()
    .RegisterDbContext<DataContext>()
    .AddFiltering()
    .AddSorting()
    .AddProjections()
    .AddMutationConventions(applyToAllMutations: true)
    .AddQueryType<Query>()
    .AddMutationType<Mutation>();

var app = builder.Build();
app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
app.MapGraphQL();

app.Run();