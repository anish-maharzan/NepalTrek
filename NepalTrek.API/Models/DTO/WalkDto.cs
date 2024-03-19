﻿namespace NepalTrek.API.Models.DTO
{
    public class WalkDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double LengthInKm { get; set; }
        public string? WalkImageUrl { get; set; }

        public RegionDtoV1 Region { get; set; }
        public DifficultyDto Difficulty { get; set; }
    }
}
