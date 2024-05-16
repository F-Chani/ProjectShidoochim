using Solid.API.Mapping;
using Solid.API.Middlewares;
using Solid.Core.Mapping;
using Solid.Core.Repositories;
using Solid.Core.Services;
using Solid.Data;
using Solid.Service;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddControllers();
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IGirlService,GirlService >();
builder.Services.AddScoped<IGirlRepository, GirlRepository>();
builder.Services.AddScoped<IGuyService,GuyService >();
builder.Services.AddScoped<IGuyRepository, GuyRepository>();
builder.Services.AddScoped<IMatchmakerRepository, MatchmakerRepository>();
builder.Services.AddScoped<IMatchmakerService, MatchmakerService>();
builder.Services.AddScoped<IProposalService, ProposalService>();
builder.Services.AddScoped<IProposalRepository, ProposalRepository>();
builder.Services.AddAutoMapper(typeof(MappingProfile),typeof(PostModelsMappingProfile));

builder.Services.AddDbContext<DataContext>();
//builder.Services.AddSingleton<DataContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseMiddleware<TrackMiddleware>();

app.UseMiddleware<ShabbatMiddleware>();
//middleware
app.Use(async (context, next) =>
{
    Console.WriteLine("middleware start");
    var shabbat = false;

    if (shabbat)
    {
        context.Response.StatusCode = StatusCodes.Status400BadRequest;
        return;
    }
    // Do work that can write to the Response.
    await next(context);
    Console.WriteLine("middleware end");
    // Do logging or other work that doesn't write to the Response.
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
