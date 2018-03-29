namespace Blog.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private BlogDBContext dbContext;

        public BlogDBContext Init()
        {
            return dbContext ?? (dbContext = new BlogDBContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}