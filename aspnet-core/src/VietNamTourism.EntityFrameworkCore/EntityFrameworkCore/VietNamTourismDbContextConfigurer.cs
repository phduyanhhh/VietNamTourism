using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace VietNamTourism.EntityFrameworkCore;

public static class VietNamTourismDbContextConfigurer
{
    public static void Configure(DbContextOptionsBuilder<VietNamTourismDbContext> builder, string connectionString)
    {
        builder.UseSqlServer(connectionString);
    }

    public static void Configure(DbContextOptionsBuilder<VietNamTourismDbContext> builder, DbConnection connection)
    {
        builder.UseSqlServer(connection);
    }
}
