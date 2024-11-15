using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentRiwi.DTOs;
using AssessmentRiwi.Models;
using AssessmentRiwi.Repositories;

namespace AssessmentRiwi.Services;

public class AppointmentService : IAppointmentService
{
    private readonly IAppointmentRepository _appointmentRepository;

    public AppointmentService(IAppointmentRepository appointmentRepository)
    {
        _appointmentRepository = appointmentRepository;
    }

    public async Task<AppointmentDTO> GetByIdAsync(int appointmentId)
    {
        var appointment = await _appointmentRepository.GetByIdAsync(appointmentId);
        if (appointment == null) return null;

        return new AppointmentDTO
        {
            PatientId = appointment.PatientId,
            DoctorId = appointment.DoctorId,
            AppointmentDate = appointment.AppointmentDate,
            Reason = appointment.Reason,
            Status = appointment.Status
        };
    }

    public async Task<IEnumerable<AppointmentDTO>> GetAllAsync()
    {
        var appointments = await _appointmentRepository.GetAllAsync();
        return appointments.Select(a => new AppointmentDTO
        {
            PatientId = a.PatientId,
            DoctorId = a.DoctorId,
            AppointmentDate = a.AppointmentDate,
            Reason = a.Reason,
            Status = a.Status
        });
    }

    public async Task<AppointmentDTO> AddAsync(AppointmentDTO appointmentDto)
    {
        var appointment = new Appointment
        {
            PatientId = appointmentDto.PatientId,
            DoctorId = appointmentDto.DoctorId,
            AppointmentDate = appointmentDto.AppointmentDate,
            Reason = appointmentDto.Reason,
            Status = appointmentDto.Status
        };

        var addedAppointment = await _appointmentRepository.AddAsync(appointment);

        return new AppointmentDTO
        {
            PatientId = addedAppointment.PatientId,
            DoctorId = addedAppointment.DoctorId,
            AppointmentDate = addedAppointment.AppointmentDate,
            Reason = addedAppointment.Reason,
            Status = addedAppointment.Status
        };
    }

    public async Task<AppointmentDTO> UpdateAsync(int appointmentId, AppointmentDTO appointmentDto)
    {
        var appointment = await _appointmentRepository.GetByIdAsync(appointmentId);
        if (appointment == null) return null;

        appointment.PatientId = appointmentDto.PatientId;
        appointment.DoctorId = appointmentDto.DoctorId;
        appointment.AppointmentDate = appointmentDto.AppointmentDate;
        appointment.Reason = appointmentDto.Reason;
        appointment.Status = appointmentDto.Status;

        var updatedAppointment = await _appointmentRepository.UpdateAsync(appointment);

        return new AppointmentDTO
        {
            PatientId = updatedAppointment.PatientId,
            DoctorId = updatedAppointment.DoctorId,
            AppointmentDate = updatedAppointment.AppointmentDate,
            Reason = updatedAppointment.Reason,
            Status = updatedAppointment.Status
        };
    }

    public async Task DeleteAsync(int appointmentId)
    {
        await _appointmentRepository.DeleteAsync(appointmentId);
    }


}
