using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentRiwi.Data;
using AssessmentRiwi.Models;
using Microsoft.EntityFrameworkCore;

namespace AssessmentRiwi.Repositories;

public class PatientRepository : IPatientRepository
{
     private readonly ApplicationDbContext _context;

    public PatientRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Patient> GetByIdAsync(int patientId)
    {
        return await _context.Patients
            .Include(p => p.User)   
            .FirstOrDefaultAsync(p => p.Id == patientId);
    }

    public async Task<IEnumerable<Patient>> GetAllAsync()
    {
        return await _context.Patients
            .Include(p => p.User)  
            .ToListAsync();
    }

    public async Task<Patient> AddAsync(Patient patient)
    {
        _context.Patients.Add(patient);
        await _context.SaveChangesAsync();
        return patient;
    }

    public async Task<Patient> UpdateAsync(Patient patient)
    {
        _context.Patients.Update(patient);
        await _context.SaveChangesAsync();
        return patient;
    }

    public async Task DeleteAsync(int patientId)
    {
        var patient = await GetByIdAsync(patientId);
        if (patient != null)
        {
            _context.Patients.Remove(patient);
            await _context.SaveChangesAsync();
        }
    }


}
