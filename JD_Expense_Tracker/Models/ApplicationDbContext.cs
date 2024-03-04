using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using Microsoft.Extensions.Options;
using System;

/// <summary>
///Dependency Injection(DI) is a design pattern in which a class receives its dependencies 
///from external sources rather than creating them itself. This pattern promotes loose coupling and 
///makes classes more testable and maintainable.
///
/// DbContextOptions: This parameter is used to configure the context. It contains information such as the database provider to use, connection string, and other options related to database access.
///base(options): This calls the base constructor of DbContext with the DbContextOptions parameter, allowing DbContext to be configured with the provided options.
/// </summary>
public class ApplicationDbContext:DbContext
{
    //will be created through dependency injection
        public ApplicationDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }
 
}
