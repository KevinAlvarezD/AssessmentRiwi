using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentRiwi.DTOs;
using AssessmentRiwi.Models;
using AssessmentRiwi.Repositories;

namespace AssessmentRiwi.Services;

public class AvailabilityService : IAvailabilityService
{
    private readonly IAvailabilityRepository _availabilityRepository;

    public AvailabilityService(IAvailabilityRepository availabilityRepository)
    {
        _availabilityRepository = availabilityRepository;
    }

    public async Task<AvailabilityDTO> GetByIdAsync(int availabilityId)
    {
        var availability = await _availabilityRepository.GetByIdAsync(availabilityId);
        if (availability == null)
        {
            return null;
        }

        var availabilityDto = new AvailabilityDTO
        {
            DoctorId = availability.DoctorId,
            Date = availability.Date,
            StartHour = availability.StartHour,
            EndHour = availability.EndHour
        };

        return availabilityDto;
    }

    public async Task<IEnumerable<AvailabilityDTO>> GetAllAsync()
    {
        var availabilities = await _availabilityRepository.GetAllAsync();

        var availabilityDtos = new List<AvailabilityDTO>();
        foreach (var availability in availabilities)
        {
            availabilityDtos.Add(new AvailabilityDTO
            {
                DoctorId = availability.DoctorId,
                Date = availability.Date,
                StartHour = availability.StartHour,
                EndHour = availability.EndHour
            });
        }

        return availabilityDtos;
    }

    public async Task<AvailabilityDTO> AddAsync(AvailabilityDTO availabilityDto)
    {
        var availability = new Availability
        {
            DoctorId = availabilityDto.DoctorId,
            Date = availabilityDto.Date,
            StartHour = availabilityDto.StartHour,
            EndHour = availabilityDto.EndHour
        };

        var addedAvailability = await _availabilityRepository.AddAsync(availability);

        var addedAvailabilityDto = new AvailabilityDTO
        {
            DoctorId = addedAvailability.DoctorId,
            Date = addedAvailability.Date,
            StartHour = addedAvailability.StartHour,
            EndHour = addedAvailability.EndHour
        };

        return addedAvailabilityDto;
    }

    public async Task<AvailabilityDTO> UpdateAsync(int availabilityId, AvailabilityDTO availabilityDto)
    {
        var availability = await _availabilityRepository.GetByIdAsync(availabilityId);
        if (availability == null)
        {
            return null;  
        }

        availability.DoctorId = availabilityDto.DoctorId;
        availability.Date = availabilityDto.Date;
        availability.StartHour = availabilityDto.StartHour;
        availability.EndHour = availabilityDto.EndHour;

        var updatedAvailability = await _availabilityRepository.UpdateAsync(availability);

        var updatedAvailabilityDto = new AvailabilityDTO
        {
            DoctorId = updatedAvailability.DoctorId,
            Date = updatedAvailability.Date,
            StartHour = updatedAvailability.StartHour,
            EndHour = updatedAvailability.EndHour
        };

        return updatedAvailabilityDto;
    }

    public async Task DeleteAsync(int availabilityId)
    {
        await _availabilityRepository.DeleteAsync(availabilityId);
    }


}
