using OA.Data.Entities;

namespace OA.Services.Services
{
    public interface IUserProfileService
    {
        UserProfile GetUserProfile(long id);
    }
}
