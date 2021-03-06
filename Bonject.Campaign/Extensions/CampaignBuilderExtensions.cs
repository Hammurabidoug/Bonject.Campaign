﻿using Bonject.Campaign.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bonject.Campaign.Extensions
{
    public static class CampaignBuilderExtensions
    {
        public static CampaignBuilder WithCajolingInitiation(this CampaignBuilder builder)
        {
            builder.WithInitiationStrategy<CajoleInitiationStrategy>();

            return builder;
        }
    }
}
