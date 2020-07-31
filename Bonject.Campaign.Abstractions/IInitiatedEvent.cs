using System;
using System.Collections.Generic;
using System.Text;

namespace Bonject.Campaign.Abstractions
{
    public interface IInitiatedEvent
    {
        ICampaign Campaign { get; }
    }
}
