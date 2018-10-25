using DispatchPro.Core.SharedKernel;

namespace DispatchPro.Core.Interfaces
{
    public interface IDomainEventDispatcher
    {
        void Dispatch(BaseDomainEvent domainEvent);
    }
}