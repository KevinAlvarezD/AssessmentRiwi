using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentRiwi.Models;

namespace AssessmentRiwi.Repositories;

public interface IAvailabilityRepository
{
    Task<Availability> GetByIdAsync(int availabilityId);
    Task<IEnumerable<Availability>> GetAllAsync();
    Task<Availability> AddAsync(Availability availability);
    Task<Availability> UpdateAsync(Availability availability);
    Task DeleteAsync(int availabilityId);


}
