using System;

namespace Blog.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        BlogDBContext Init();
    }
}