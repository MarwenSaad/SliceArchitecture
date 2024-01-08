// <copyright file="Tutoriel.cs" company="Nieze">
// Copyright (c) Nieze. All rights reserved.
// </copyright>

namespace Nieze.SliceArchitecture.API.Entites;

/// <summary>
/// Tutoriel entity.
/// </summary>
public partial class Tutoriel
{
    /// <summary>
    /// Gets or sets Id.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets Title.
    /// </summary>
    public string Title { get; set; } = null!;

    /// <summary>
    /// Gets or sets Description.
    /// </summary>
    public string Description { get; set; } = null!;
}