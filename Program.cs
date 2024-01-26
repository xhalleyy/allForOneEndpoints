using allForOneEndpoints.Services.AddNumbers;
using allForOneEndpoints.Services.AskingQuestions;
using allForOneEndpoints.Services.GreaterOrLess;
using allForOneEndpoints.Services.MadLib;
using allForOneEndpoints.Services.Magic8Ball;
using allForOneEndpoints.Services.OddOrEven;
using allForOneEndpoints.Services.RestaurantPicker;
using allForOneEndpoints.Services.ReverseIt1;
using allForOneEndpoints.Services.ReverseIt2;
using allForOneEndpoints.Services.SayHello;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddCors(option => {
    option.AddPolicy("CorsPolicy", 
                    builder => {
                        builder.AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowAnyOrigin();
                    });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ISayHelloService, SayHelloService>();
builder.Services.AddScoped<IAddNumbersService, AddNumbersService>();
builder.Services.AddScoped<IAskingQuestionsService, AskingQuestionsService>();
builder.Services.AddScoped<IGreaterOrLessService, GreaterOrLessService>();
builder.Services.AddScoped<IMadLibService, MadLibService>();
builder.Services.AddScoped<IOddOrEvenService, OddOrEvenService>();
builder.Services.AddScoped<IReverseIt1Service, ReverseIt1Service>();
builder.Services.AddScoped<IReverseIt2Service, ReverseIt2Service>();
builder.Services.AddScoped<IMagic8BallService, Magic8BallService>();
builder.Services.AddScoped<IRestaurantPickerService, RestaurantPickerService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("CorsPolicy");

app.MapControllers();

app.Run();
