using OA.Data.Entities;
using OA.Repo.Repositories;

namespace OA.Services.Services
{
    public class UserProfileService : IUserProfileService
    {
        private IRepository<UserProfile> _userProfileRepository;

        public UserProfileService(IRepository<UserProfile> userProfileRepository)
        {
            this._userProfileRepository = userProfileRepository;
        }
        public UserProfile GetUserProfile(long id)
        {
            return _userProfileRepository.Get(id);
        }
    }
}
