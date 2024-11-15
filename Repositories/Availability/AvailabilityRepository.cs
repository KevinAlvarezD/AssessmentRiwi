using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentRiwi.Data;
using AssessmentRiwi.Models;
using Microsoft.EntityFrameworkCore;

namespace AssessmentRiwi.Repositories;

public class AvailabilityRepository : IAvailabilityRepository
{
    private readonly ApplicationDbContext _context;

    public AvailabilityRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Availability> GetByIdAsync(int availabilityId)
    {
        return await _context.Availabilities
            .Include(a => a.Doctor)
            .FirstOrDefaultAsync(a => a.Id == availabilityId);
    }

    public async Task<IEnumerable<Availability>> GetAllAsync()
    {
        return await _context.Availabilities
            .Include(a => a.Doctor)
            .ToListAsync();
    }

    public async Task<Availability> AddAsync(Availability availability)
    {
        _context.Availabilities.Add(availability);
        await _context.SaveChangesAsync();
        return availability;
    }

    public async Task<Availability> UpdateAsync(Availability availability)
    {
        _context.Availabilities.Update(availability);
        await _context.SaveChangesAsync();
        return availability;
    }

    public async Task DeleteAsync(int availabilityId)
    {
        var availability = await GetByIdAsync(availabilityId);
        if (availability != null)
        {
            _context.Availabilities.Remove(availability);
            await _context.SaveChangesAsync();
        }
    }


}
