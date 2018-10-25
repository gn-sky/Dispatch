using DispatchPro.Core.SharedKernel;

namespace DispatchPro.Core.Interfaces
{
    public interface IHandle<T> where T : BaseDomainEvent
    {
        void Handle(T domainEvent);
    }
}