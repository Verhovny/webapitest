var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


// Настройка кросс-доменных запросов, чтобы на API:30 мог стучаться клиент CLIENT:3000
// builder.Services.AddCors(options =>  options.AddPolicy("CorsPolicy",

// builder =>{
//     builder.WithOrigins("http://localhost:3000");
// }
// ));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
