using DispatchPro.Core.Interfaces;
using DispatchPro.Core.SharedKernel;

namespace DispatchPro.Tests
{
    public class NoOpDomainEventDispatcher : IDomainEventDispatcher
    {
        public void Dispatch(BaseDomainEvent domainEvent) { }
    }
}
