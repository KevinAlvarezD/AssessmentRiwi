using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentRiwi.Models;

namespace AssessmentRiwi.Repositories;

public interface IAppointmentRepository
{
    Task<Appointment> GetByIdAsync(int appointmentId);  
    Task<IEnumerable<Appointment>> GetAllAsync();      
    Task<Appointment> AddAsync(Appointment appointment); 
    Task<Appointment> UpdateAsync(Appointment appointment); 
    Task DeleteAsync(int appointmentId);


}
