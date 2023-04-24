using Dev.Fluent.Common;
using Dev.Fluent.Data.Context;
using Dev.Fluent.IoC;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration.GetSection(nameof(ParameterOptions));
var parametterOptions = configuration.Get<ParameterOptions>();

// Add services to the container.
builder.Services.Configure<ParameterOptions>(configuration);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new()
    {
        Title = "Fluent Validation",
        Version = "v1"
    });
});
builder.Services.InjectFluentValidation();
builder.Services.AddMvc();
builder.Services.InjectSqlServer<FluentApiDbContext>(parametterOptions.ConnectionString);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(ui =>
        ui.SwaggerEndpoint("/swagger/v1/swagger.json", "Fluent Validation"));
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();