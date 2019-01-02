﻿using HL.Diners.Core.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HL.Diners.Core.Data
{
    public interface IDinersRepository
    {
        Task<Cycle> AddCycleAsync(Cycle cycle);
        Task<IEnumerable<Cycle>> GetCyclesAsync();
        Task<Cycle> GetCycleAsync(string id);
        Task<Cycle> GetActiveCycleByUserAsync(string userId);
        Task<Cycle> UpdateCycleAsync(Cycle cycle);
        Task RemoveCycleAsync(string id);
        bool CycleExists(string id);

    }
}
