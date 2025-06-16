using Abp.Zero.EntityFrameworkCore;
using VietNamTourism.Authorization.Roles;
using VietNamTourism.Authorization.Users;
using VietNamTourism.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace VietNamTourism.EntityFrameworkCore;

public class VietNamTourismDbContext : AbpZeroDbContext<Tenant, Role, User, VietNamTourismDbContext>
{
    /* Define a DbSet for each entity of the application */

    public VietNamTourismDbContext(DbContextOptions<VietNamTourismDbContext> options)
        : base(options)
    {
    }
}
