using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentRiwi.DTOs;
using AssessmentRiwi.Models;
using AssessmentRiwi.Repositories;

namespace AssessmentRiwi.Services;

public class DoctorService : IDoctorService 
{
    private readonly IDoctorRepository _doctorRepository;

    public DoctorService(IDoctorRepository doctorRepository)
    {
        _doctorRepository = doctorRepository;
    }

    public async Task<IEnumerable<DoctorDTO>> GetAllDoctorsAsync()
    {
        var doctors = await _doctorRepository.GetAllAsync();
        return doctors.Select(d => new DoctorDTO
        {
            UserId = d.UserId,
            Specialty = d.Specialty,
            OfficeHours = d.OfficeHours
        });
    }

    public async Task<DoctorDTO> GetDoctorByIdAsync(int id)
    {
        var doctor = await _doctorRepository.GetByIdAsync(id);
        if (doctor == null) return null;

        return new DoctorDTO
        {
            UserId = doctor.UserId,
            Specialty = doctor.Specialty,
            OfficeHours = doctor.OfficeHours
        };
    }

    public async Task AddDoctorAsync(DoctorDTO doctorDto)
    {
        var doctor = new Doctor
        {
            UserId = doctorDto.UserId,
            Specialty = doctorDto.Specialty,
            OfficeHours = doctorDto.OfficeHours
        };

        await _doctorRepository.AddAsync(doctor);
    }

    public async Task UpdateDoctorAsync(int id, DoctorDTO doctorDto)
    {
        var doctor = await _doctorRepository.GetByIdAsync(id);
        if (doctor == null) throw new Exception("Doctor no encontrado");

        doctor.Specialty = doctorDto.Specialty;
        doctor.OfficeHours = doctorDto.OfficeHours;

        await _doctorRepository.UpdateAsync(doctor);
    }

    public async Task DeleteDoctorAsync(int id)
    {
        await _doctorRepository.DeleteAsync(id);
    }



}
