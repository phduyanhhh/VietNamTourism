using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace VietNamTourism.EntityFrameworkCore;

public static class VietNamTourismDbContextConfigurer
{
	public static void Configure(DbContextOptionsBuilder<VietNamTourismDbContext> builder, string connectionString)
	{
		builder.UseNpgsql(connectionString, x => x.UseNetTopologySuite());
	}

	public static void Configure(DbContextOptionsBuilder<VietNamTourismDbContext> builder, DbConnection connection)
	{
		builder.UseNpgsql(connection, x => x.UseNetTopologySuite());
	}
}
