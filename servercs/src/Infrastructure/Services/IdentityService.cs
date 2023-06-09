using Microsoft.Extensions.Configuration;
using Serenity.Application.Interfaces;
using Serenity.Domain.Entities;

namespace Serenity.Infrastructure.Services;

public class IdentityService
{
    private readonly IConfiguration configuration;

    public IdentityService(IConfiguration configuration)
    {
        this.configuration = configuration;
    }
}
