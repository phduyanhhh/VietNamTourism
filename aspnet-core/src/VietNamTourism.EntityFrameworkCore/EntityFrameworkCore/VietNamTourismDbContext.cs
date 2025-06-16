using Abp.Zero.EntityFrameworkCore;
using VietNamTourism.Authorization.Roles;
using VietNamTourism.Authorization.Users;
using VietNamTourism.MultiTenancy;
using Microsoft.EntityFrameworkCore;
using System;
using VietNamTourism.Entities;

namespace VietNamTourism.EntityFrameworkCore;

public class VietNamTourismDbContext : AbpZeroDbContext<Tenant, Role, User, VietNamTourismDbContext>
{
	/* Define a DbSet for each entity of the application */
	public DbSet<Categories> Categories { get; set; }
	public DbSet<Provinces> Provinces { get; set; }
	public DbSet<Districts> Districts { get; set; }
	public DbSet<Communes> Communes { get; set; }
	public DbSet<AdministrativeLocations> AdministrativeLocations { get; set; }
	public VietNamTourismDbContext(DbContextOptions<VietNamTourismDbContext> options)
			: base(options)
	{
		AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
	}
}
