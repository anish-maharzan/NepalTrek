namespace NepalTrek.API.Models.DTO
{
    public class RegionDtoV1
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string? RegionImageUrl { get; set; }
    }

    public class RegionDtoV2
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string FullName { get; set; }
        public string? RegionImageUrl { get; set; }
    }
}
