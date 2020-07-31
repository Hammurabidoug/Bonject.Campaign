using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bonject.Campaign.DependencyInjection
{
    public class CampaignBuilder
    {
        public CampaignBuilder(IServiceCollection services)
        {
            this.Services = services;
        }

        internal IServiceCollection Services { get; private set; }
    }
}
