using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentRiwi.DTOs;

namespace AssessmentRiwi.Services;

public interface IAvailabilityService
{
    Task<AvailabilityDTO> GetByIdAsync(int availabilityId);
    Task<IEnumerable<AvailabilityDTO>> GetAllAsync();
    Task<AvailabilityDTO> AddAsync(AvailabilityDTO availabilityDto);
    Task<AvailabilityDTO> UpdateAsync(int availabilityId, AvailabilityDTO availabilityDto);
    Task DeleteAsync(int availabilityId);


}
