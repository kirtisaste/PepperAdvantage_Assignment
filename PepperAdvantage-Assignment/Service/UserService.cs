using PepperAdvantage_Assignment.DTOs;
using PepperAdvantage_Assignment.Model;
using PepperAdvantage_Assignment.Repository;

namespace PepperAdvantage_Assignment.Service
{
    public class UserService
    {
       
        private UserRepository _userRepository;
        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public async Task<List<UserResponse>> GetUsers()
        {
            List<User> users = await _userRepository.GetUsers();

            List<UserResponse> userResponses = users.Select(a=> new UserResponse
            {
                ID = a.ID,
                FullNmae = a.FullNmae,
                UserName = a.UserName,
            }).ToList();

            return userResponses;
        }
    }
}
