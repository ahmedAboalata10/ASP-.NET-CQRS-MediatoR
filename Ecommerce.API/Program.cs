using Ecommmerce.Application.Shared;
using Ecommerce.Infrastructure.Shared;
using Ecommerce.Persistence.Shared ;
using Ecommmerce.Application.Persistance.Email;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.ConfigureApllicationService();
builder.Services.ConfiureInfrastrctureServise(builder.Configuration);
builder.Services.ConfiurePersistenceServise(builder.Configuration);
builder.Services.Configure<EmailSetting>(builder.Configuration.GetSection("EmailSettings"));

builder.Services.AddCors(opt=>
{
    opt.AddPolicy("CORSPolicy", p =>
    {
        p.AllowAnyOrigin().
        AllowAnyHeader().
        AllowAnyMethod();
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors("CORSPolicy");
app.MapControllers();

app.Run();
