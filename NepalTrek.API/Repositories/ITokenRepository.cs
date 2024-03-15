using Microsoft.AspNetCore.Identity;

namespace NepalTrek.API.Repositories
{
    public interface ITokenRepository
    {
        string CreateJWTToken(IdentityUser user, List<string> roles);
    }
}
