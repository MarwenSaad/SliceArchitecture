// <copyright file="PortfolioContext.cs" company="Nieze">
// Copyright (c) Nieze. All rights reserved.
// </copyright>

namespace Nieze.SliceArchitecture.API.Entites;

using Microsoft.EntityFrameworkCore;

/// <inheritdoc/>
public partial class PortfolioContext : DbContext
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PortfolioContext"/> class.
    /// </summary>
    /// <param name="options">DbContextOptions for PortfolioContext.</param>
    public PortfolioContext(DbContextOptions<PortfolioContext> options)
        : base(options)
    {
    }

    /// <summary>
    /// Gets or sets dbSet of the entity Tutoriel.
    /// </summary>
    public virtual DbSet<Tutoriel> Tutoriel { get; set; }

    /// <inheritdoc/>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new Database.Configurations.TutorielConfiguration());
    }
}