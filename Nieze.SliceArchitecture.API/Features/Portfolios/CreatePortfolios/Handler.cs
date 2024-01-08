// <copyright file="Handler.cs" company="Nieze">
// Copyright (c) Nieze. All rights reserved.
// </copyright>

namespace Nieze.SliceArchitecture.API.Features.Portfolios.CreatePortfolios;

/// <summary>
/// Handler for the use case create Portfolio.
/// </summary>
public sealed class Handler(PortfolioContext context) : IRequestHandler<Command, int>
{
    /// <inheritdoc/>
    public async Task<int> Handle(Command request, CancellationToken cancellationToken)
    {
        Tutoriel tutoriel = new Tutoriel()
        {
            Title = request.Title,
            Description = request.Description,
        };
        context.Add(tutoriel);
        await context.SaveChangesAsync();

        return tutoriel.Id;
    }
}