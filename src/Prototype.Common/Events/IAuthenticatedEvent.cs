using System;

namespace Prototype.Common.Events
{
    public interface IAuthenticatedEvent : IEvent
    {
         Guid UserId { get; }
    }
}