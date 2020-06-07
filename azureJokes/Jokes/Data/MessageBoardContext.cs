using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Jokes.Data
{
  public class JokesContext : DbContext
  {
    public JokesContext()
      : base("DefaultConnection")
    {
      this.Configuration.LazyLoadingEnabled = false;
      this.Configuration.ProxyCreationEnabled = false;

      Database.SetInitializer(
        new MigrateDatabaseToLatestVersion<JokesContext, JokesMigrationsConfiguration>()
        );
    }

    public DbSet<Topic> Topics { get; set; }
    public DbSet<Reply> Replies { get; set; }

  }
}