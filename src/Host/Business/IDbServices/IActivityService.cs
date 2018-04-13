﻿using Host.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Host.Business.IDbServices
{
    public interface IActivityService
    {
        Task<int> AddActivity(ActivityDto requestDto);
        Task<int> UpdateActivity(ActivityDto requestDto);
        ActivityDto GetActivityById(int id);
        List<ActivityDto> GetAllActivity();
    }
}
