using Host.Business.IDbServices;
using Host.Data;
using Host.Models.AccountViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Host.Business.DbServices
{
    public class RoleService : IRoleService
    {
        private readonly IServiceProvider _serviceProvider;

        public RoleService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public List<RolesModel> GetAllRoles()
        {
            var scope = _serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope();
            var context = scope.ServiceProvider.GetService<ApplicationDbContext>();

            return context.Roles
                           .AsNoTracking()
                           .Select(i => new RolesModel
                           {
                               RoleId = i.Id,
                               Name = i.Name,
                               NormalizedName = i.NormalizedName
                           })
                           .ToList();
        }
    }
}
