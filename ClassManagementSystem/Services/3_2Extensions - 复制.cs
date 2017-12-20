using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
//using Xmu.Crms.Shared.Exceptions;
//using Xmu.Crms.Shared.Models;
//using Xmu.Crms.Shared.Service;

namespace ClassManagementSystem.Services.IServices
{
    public static class Group1Extensions
    {
        // 为每一个你写的Service写一个这样的函数，把 UserService 替换为你实现的 Service
        public static IServiceCollection AddGroup1UserService(this IServiceCollection serviceCollection)
        {
            return serviceCollection.AddScoped<IUserService, UserService>();
        }
    }
}
