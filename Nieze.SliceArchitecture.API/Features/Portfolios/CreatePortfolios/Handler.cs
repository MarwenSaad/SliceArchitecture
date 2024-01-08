// <copyright file="Handler.cs" company="Nieze">
// Copyright (c) Nieze. All rights reserved.
// </copyright>

namespace Nieze.SliceArchitecture.API.Features.Portfolios.CreatePortfolios;

/// <summary>
/// Handler for the use case create Portfolio.
/// </summary>
public sealed class Handler : IRequestHandler<Command, int>
{
    private readonly PortfolioContext context;

    /// <summary>
    /// Initializes a new instance of the <see cref="Handler"/> class.
    /// </summary>
    /// <param name="context">PortfolioContext.</param>
    public Handler(PortfolioContext context)
    {
        this.context = context;
    }

    /// <inheritdoc/>
    public async Task<int> Handle(Command request, CancellationToken cancellationToken)
    {
        Tutoriel tutoriel = new Tutoriel()
        {
            Title = request.Title,
            Description = request.Description,
        };
        this.context.Add(tutoriel);
        await this.context.SaveChangesAsync();

        return tutoriel.Id;
    }
}