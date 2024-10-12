using System.Text.Json.Serialization;
using LearnLumin.BLL.Interfaces;
using LearnLumin.BLL.Mapper;
using LearnLumin.BLL.Services;
using LearnLumin.DAL;
using LearnLumin.DAL.Entities.UsersAndRoles;
using LearnLumin.DAL.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers().AddJsonOptions(options => 
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure the HTTP request pipeline.
var connectionString = builder.Configuration.GetConnectionString("LearnLuminContext");

builder.Services.AddDbContext<LearnLuminContext>(options =>
{
    options.UseSqlServer(connectionString);
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAnyOrigin", 
        policyBuilder => policyBuilder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IProfileService, ProfileService>();
builder.Services.AddTransient<IRepository<User>, BaseRepository<User>>();
builder.Services.AddTransient<IRepository<Role>, BaseRepository<Role>>();
builder.Services.AddTransient<IRepository<Profile>, BaseRepository<Profile>>();
builder.Services.AddTransient<UserRepository>();
builder.Services.AddTransient<ProfileRepository>();







var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseMiddleware<ErrorHandlingMiddleware>(); // for global error handling

app.UseHttpsRedirection();

app.UseCors("AllowAnyOrigin");

app.MapControllers();

app.Run();