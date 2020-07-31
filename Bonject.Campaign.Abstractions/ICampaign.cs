using System;
using System.Threading.Tasks;

namespace Bonject.Campaign.Abstractions
{
    public interface ICampaign
    {
        string Name { get; set; }

        Task<IInitiatedEvent> Initiate();
    }
}
