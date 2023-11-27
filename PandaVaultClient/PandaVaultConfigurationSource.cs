﻿using Microsoft.Extensions.Configuration;

namespace PandaVaultClient;

public class PandaVaultConfigurationSource : IConfigurationSource
{
    public PandaVaultConfigurationSource(IConfiguration existingConfiguration)
    {
        ExistingConfiguration = existingConfiguration;
    }

    IConfiguration ExistingConfiguration { get; set; }

    public IConfigurationProvider Build(IConfigurationBuilder builder)
    {
        return new PandaVaultConfigurationProvider(ExistingConfiguration);
    }
}