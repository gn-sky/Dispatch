using Ardalis.GuardClauses;
using DispatchPro.Core.Events;
using DispatchPro.Core.Interfaces;

namespace DispatchPro.Core.Services
{
    public class ToDoItemService : IHandle<ToDoItemCompletedEvent>
    {
        public void Handle(ToDoItemCompletedEvent domainEvent)
        {
            Guard.Against.Null(domainEvent, nameof(domainEvent));

            // Do Nothing
        }
    }
}
