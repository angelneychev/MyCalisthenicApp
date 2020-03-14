﻿namespace MyCalisthenicApp.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using MyCalisthenicApp.Data;
    using MyCalisthenicApp.Services.Contracts;
    using MyCalisthenicApp.ViewModels.Memberships;

    public class MembershipsService : IMembershipsService
    {
        private readonly MyCalisthenicAppDbContext dbContext;
        private readonly IMapper mapper;

        public MembershipsService(MyCalisthenicAppDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<MembershipPlanViewModel>> GetAllMembershipPlans()
        {
            var memberships = await this.dbContext
                .Memberships
                .OrderBy(p => p.YearlyPrice)
                .ToListAsync();

            var membershipsViewModel = this.mapper.Map<IEnumerable<MembershipPlanViewModel>>(memberships);

            return membershipsViewModel;
        }
    }
}