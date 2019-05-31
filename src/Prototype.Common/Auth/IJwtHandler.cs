using System;

namespace Prototype.Common.Auth
{
    public interface IJwtHandler
    {
        JsonWebToken Create(Guid userId);     
    }
}