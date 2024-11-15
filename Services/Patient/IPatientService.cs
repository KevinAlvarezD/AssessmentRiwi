using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentRiwi.DTOs;

namespace AssessmentRiwi.Services;

public interface IPatientService
{
    Task<PatientDTO> GetByIdAsync(int patientId);
    Task<IEnumerable<PatientDTO>> GetAllAsync();
    Task<PatientDTO> AddAsync(PatientDTO patientDto);
    Task<PatientDTO> UpdateAsync(int patientId, PatientDTO patientDto);
    Task DeleteAsync(int patientId);
}
