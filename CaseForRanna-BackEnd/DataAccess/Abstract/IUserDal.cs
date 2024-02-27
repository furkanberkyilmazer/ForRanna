﻿using CaseForRanna_BackEnd.Entities;

namespace CaseForRanna_BackEnd.DataAccess.Abstract
{
    public interface IUserDal : IGenericDal<User>
    {
        Task<List<User>> GetByRoleIdAsync(int RoleId);
    }
}
