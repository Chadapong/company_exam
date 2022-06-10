using Microsoft.EntityFrameworkCore;
using vendor_store_web_api.Middlewares;
using vendor_store_web_api.Services.UserService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// db context
builder.Services.AddDbContext<vendor_store_web_api.ApplicationDbContext>(opts =>
{
opts.UseNpgsql(builder.Configuration.GetConnectionString("postgresql"));
opts.UseSnakeCaseNamingConvention(); 
}
);



// user service DI
builder.Services.AddScoped<IUserService, UserService>();

// mapper between model
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddControllersWithViews();


var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Cors
app.UseCors(x => x
    .SetIsOriginAllowed(origin => true)
    .AllowAnyMethod()
    .AllowAnyHeader()
    .AllowCredentials());


// global error handler
app.UseMiddleware<ErrorHandlerMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
