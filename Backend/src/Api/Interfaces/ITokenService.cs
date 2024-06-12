using Pharmacy.Api.Models;

namespace Pharmacy.Api.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
