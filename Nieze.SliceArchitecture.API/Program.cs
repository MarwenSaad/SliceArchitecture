// <copyright file="Program.cs" company="Nieze">
// Copyright (c) Nieze. All rights reserved.
// </copyright>

using Microsoft.EntityFrameworkCore;
using Nieze.SliceArchitecture.API.Entites;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<PortfolioContext>(o =>
    o.UseSqlServer(builder.Configuration.GetConnectionString("PortfolioConnectionString")));

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

app.Run();