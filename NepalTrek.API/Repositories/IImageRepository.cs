using NepalTrek.API.Models.Domain;
using System.Net;

namespace NepalTrek.API.Repositories
{
    public interface IImageRepository
    {
        Task<Image> Upload(Image image);
    }
}
