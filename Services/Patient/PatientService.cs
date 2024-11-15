using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentRiwi.DTOs;
using AssessmentRiwi.Models;
using AssessmentRiwi.Repositories;


namespace AssessmentRiwi.Services;

public class PatientService : IPatientService
{
    private readonly IPatientRepository _patientRepository;

    public PatientService(IPatientRepository patientRepository)
    {
        _patientRepository = patientRepository;
    }

    public async Task<PatientDTO> GetByIdAsync(int patientId)
    {
        var patient = await _patientRepository.GetByIdAsync(patientId);
        if (patient == null) return null;

        return new PatientDTO
        {
            UserId = patient.UserId,
            DateOfBirth = patient.DateOfBirth,
            MedicalHistory = patient.MedicalHistory
        };
    }

    public async Task<IEnumerable<PatientDTO>> GetAllAsync()
    {
        var patients = await _patientRepository.GetAllAsync();
        return patients.Select(p => new PatientDTO
        {
            UserId = p.UserId,
            DateOfBirth = p.DateOfBirth,
            MedicalHistory = p.MedicalHistory
        });
    }

    public async Task<PatientDTO> AddAsync(PatientDTO patientDto)
    {
        var patient = new Patient
        {
            UserId = patientDto.UserId,
            DateOfBirth = patientDto.DateOfBirth,
            MedicalHistory = patientDto.MedicalHistory
        };

        var addedPatient = await _patientRepository.AddAsync(patient);

        return new PatientDTO
        {
            UserId = addedPatient.UserId,
            DateOfBirth = addedPatient.DateOfBirth,
            MedicalHistory = addedPatient.MedicalHistory
        };
    }

    public async Task<PatientDTO> UpdateAsync(int patientId, PatientDTO patientDto)
    {
        var patient = await _patientRepository.GetByIdAsync(patientId);

        if (patient == null) return null;

        patient.UserId = patientDto.UserId;
        patient.DateOfBirth = patientDto.DateOfBirth;
        patient.MedicalHistory = patientDto.MedicalHistory;

        var updatedPatient = await _patientRepository.UpdateAsync(patient);

        return new PatientDTO
        {
            UserId = updatedPatient.UserId,
            DateOfBirth = updatedPatient.DateOfBirth,
            MedicalHistory = updatedPatient.MedicalHistory
        };
    }

    public async Task DeleteAsync(int patientId)
    {
        await _patientRepository.DeleteAsync(patientId);
    }


}
   