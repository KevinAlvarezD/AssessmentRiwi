using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentRiwi.Models;

namespace AssessmentRiwi.Repositories;

public interface IPatientRepository
{
    Task<Patient> GetByIdAsync(int patientId);
    Task<IEnumerable<Patient>> GetAllAsync();
    Task<Patient> AddAsync(Patient patient);
    Task<Patient> UpdateAsync(Patient patient);
    Task DeleteAsync(int patientId);


}
