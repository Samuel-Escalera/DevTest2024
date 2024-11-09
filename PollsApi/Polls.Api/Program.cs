using Microsoft.EntityFrameworkCore;
using Polls.Business.AutoMapper;
using Polls.Business.Service;
using Polls.Core.DTOs;
using Polls.Core.Models;
using Polls.DataAccess;
using Polls.DataAccess.Repository;

var builder = WebApplication.CreateBuilder(args);

// Context
builder.Services.AddDbContext<PollDbContext>(
    options => options.UseNpgsql(builder.Configuration.GetConnectionString("PollsDbConnection")));

// Add services to the container.
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

//app.MapControllers();

app.Run();