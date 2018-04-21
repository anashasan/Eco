﻿using Host.Models.AccountViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Host.Business.IDbServices
{
    public interface IRoleService
    {
        List<RolesModel> GetAllRoles();
        List<RolesModel> GetAllRolesById(string userId);
        string GetRoleByName(string roleName);
        void AddUserRole(string userId, string roleId);
    }
}
