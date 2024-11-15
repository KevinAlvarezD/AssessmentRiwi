using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentRiwi.Models;

namespace AssessmentRiwi.Repositories;

public interface IDoctorRepository
{
    Task<Doctor> GetByIdAsync(int id);
    Task<IEnumerable<Doctor>> GetAllAsync();
    Task AddAsync(Doctor doctor);
    Task UpdateAsync(Doctor doctor);
    Task DeleteAsync(int id);


}
