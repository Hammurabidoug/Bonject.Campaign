using Microsoft.Extensions.DependencyInjection;
using System;

namespace Bonject.Campaign.DependencyInjection
{
    public static class IServiceCollectionExtensions
    {
        public static CampaignBuilder AddCampaign(this IServiceCollection services)
        {
            return new CampaignBuilder(services);
        }
    }
}
