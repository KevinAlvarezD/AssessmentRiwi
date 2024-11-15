using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentRiwi.DTOs;

namespace AssessmentRiwi.Services;

public interface IAppointmentService
{
    Task<AppointmentDTO> GetByIdAsync(int appointmentId);
    Task<IEnumerable<AppointmentDTO>> GetAllAsync();
    Task<AppointmentDTO> AddAsync(AppointmentDTO appointmentDto);
    Task<AppointmentDTO> UpdateAsync(int appointmentId, AppointmentDTO appointmentDto);
    Task DeleteAsync(int appointmentId);


}
