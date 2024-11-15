using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentRiwi.DTOs;

namespace AssessmentRiwi.Services;

public interface IDoctorService
{
    Task<IEnumerable<DoctorDTO>> GetAllDoctorsAsync();
    Task<DoctorDTO> GetDoctorByIdAsync(int id);
    Task AddDoctorAsync(DoctorDTO doctorDto);
    Task UpdateDoctorAsync(int id, DoctorDTO doctorDto);
    Task DeleteDoctorAsync(int id);


}
