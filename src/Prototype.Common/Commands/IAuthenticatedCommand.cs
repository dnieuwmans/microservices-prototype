using System;

namespace Prototype.Common.Commands
{
    public interface IAuthenticatedCommand : ICommand
    {
         Guid UserId { get; set; }
    }
}