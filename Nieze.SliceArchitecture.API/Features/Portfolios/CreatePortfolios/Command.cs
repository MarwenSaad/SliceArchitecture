// <copyright file="Command.cs" company="Nieze">
// Copyright (c) Nieze. All rights reserved.
// </copyright>

namespace Nieze.SliceArchitecture.API.Features.Portfolios.CreatePortfolios;

using MediatR;

/// <summary>
/// Command the use case create Tutoriel.
/// </summary>
/// <param name="Title">Title the Tutoriel.</param>
/// <param name="Description">Description of the Tutoriel.</param>
public record Command(string Title, string Description) : IRequest<int>;