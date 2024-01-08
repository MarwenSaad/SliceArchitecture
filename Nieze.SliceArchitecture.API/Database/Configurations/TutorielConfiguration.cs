// <copyright file="TutorielConfiguration.cs" company="Nieze">
// Copyright (c) Nieze. All rights reserved.
// </copyright>

namespace Nieze.SliceArchitecture.API.Database.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nieze.SliceArchitecture.API.Entites;

/// <summary>
/// TutorielConfiguration class for Tutoriel entity.
/// </summary>
public partial class TutorielConfiguration : IEntityTypeConfiguration<Tutoriel>
{
    /// <summary>
    /// Configure Tutoriel entity.
    /// </summary>
    /// <param name="entity">Tutoriel entity wrapped into EntityTypeBuilder.</param>
    public void Configure(EntityTypeBuilder<Tutoriel> entity)
    {
        entity.Property(e => e.Description).HasMaxLength(1500);
        entity.Property(e => e.Title).HasMaxLength(250);
    }
}