﻿using Asp.Versioning;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NepalTrek.API.CustomActionFilters;
using NepalTrek.API.Data;
using NepalTrek.API.Models.Domain;
using NepalTrek.API.Models.DTO;
using NepalTrek.API.Repositories;
using System.Text.Json;

namespace NepalTrek.API.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    public class RegionsController : ControllerBase
    {
        private readonly NepalTrekDbContext dbContext;
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;
        private readonly ILogger<RegionsController> logger;

        public RegionsController(NepalTrekDbContext dbContext, 
            IRegionRepository regionRepository, 
            IMapper mapper,
            ILogger<RegionsController> logger)
        {
            this.dbContext = dbContext;
            this.regionRepository = regionRepository;
            this.mapper = mapper;
            this.logger = logger;
        }

        [MapToApiVersion("1.0")]
        [HttpGet]
        //[Authorize(Roles ="Reader")]
        public async Task<IActionResult> GetAllV1()
        {
            logger.LogInformation("GetAllRegions Action Method was invoked");
            // Get Data From Database - Domain models
            var regionsDomain = await regionRepository.GetAllAsync();

            logger.LogInformation($"Finished GetAllRegions request with data: {JsonSerializer.Serialize(regionsDomain)}");
            // Return DTOs
            return Ok(mapper.Map<List<RegionDtoV1>>(regionsDomain));
        }

        [MapToApiVersion("2.0")]
        [HttpGet]
        //[Authorize(Roles ="Reader")]
        public async Task<IActionResult> GetAllV2()
        {
            logger.LogInformation("GetAllRegions Action Method was invoked");
            // Get Data From Database - Domain models
            var regionsDomain = await regionRepository.GetAllAsync();

            logger.LogInformation($"Finished GetAllRegions request with data: {JsonSerializer.Serialize(regionsDomain)}");
            // Return DTOs
            return Ok(mapper.Map<List<RegionDtoV2>>(regionsDomain));
        }

        [HttpGet]
        [Route("{id:Guid}")]
        //[Authorize(Roles = "Reader")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            //var region = dbContext.Regions.Find(id);
            var regionDomain = await regionRepository.GetByIdAsync(id);

            if (regionDomain == null)
            {
                return NotFound();
            }

            var regionDto = mapper.Map<RegionDtoV1>(regionDomain);

            return Ok(regionDto);
        }

        // POST: Create New Region
        [HttpPost]
        [ValidateModel]
        //[Authorize(Roles = "Writer")]
        public async Task<IActionResult> Create([FromBody] AddRegionRequestDto dto)
        {
            // Map or convert DTO to Domain Model
            var regionDomain = mapper.Map<Region>(dto);

            // Use Domain Model to Create Region
            regionDomain = await regionRepository.CreateAsync(regionDomain);

            // Map Domain model back to DTO
            var regionDto = mapper.Map<RegionDtoV1>(regionDomain);

            return CreatedAtAction(nameof(GetById), new { id = regionDto.Id }, regionDto);
        }

        // PUT: Update Region
        [HttpPut]
        [Route("{id:Guid}")]
        [ValidateModel]
        //[Authorize(Roles = "Writer")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateRegionRequestDto dto)
        {
            var regionDomain = mapper.Map<Region>(dto);

            regionDomain = await regionRepository.UpdateAsync(id, regionDomain);

            if (regionDomain == null)
            {
                return NotFound();
            }

            // Convert domain model to DTO
            var regionDto = mapper.Map<RegionDtoV1>(regionDomain);

            return Ok(regionDto);
        }

        // DELETE: Delete Region
        [HttpDelete]
        [Route("{id:Guid}")]
        //[Authorize(Roles = "Writer, Reader")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var regionDomain = await regionRepository.DeleteAsync(id);

            if (regionDomain == null)
            {
                return NotFound();
            }

            //optional: return the deleted region back or no data back
            var regionDto = mapper.Map<RegionDtoV1>(regionDomain);

            return Ok(regionDto);
        }
    }
}
