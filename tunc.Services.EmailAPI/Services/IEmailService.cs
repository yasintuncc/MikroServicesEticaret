using tunc.Services.EmailAPI.Message;
using tunc.Services.EmailAPI.Models.Dto;

namespace tunc.Services.EmailAPI.Services
{
    public interface IEmailService
    {
        Task EmailCartAndLog(CartDto cartDto);
        Task RegisterUserEmailAndLog(string email);
        Task LogOrderPlaced(RewardsMessage rewardsDto);
    }
}
