using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new() { Title = "SwaggerDemo", Description = "Swagger Demo", Version = "v1" });
    var filename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var filePath = Path.Combine(AppContext.BaseDirectory, filename);
    options.IncludeXmlComments(filePath);
});



builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.UseSwagger();
app.UseSwaggerUI( options => { 
options.SwaggerEndpoint("/swagger/v1/swagger.json", "SwaggerDemo v1");
    options.RoutePrefix = string.Empty;
    options.DocumentTitle = "Swagger Demo";
});

app.Run();
