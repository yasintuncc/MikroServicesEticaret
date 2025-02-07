using tunc.Services.AuthAPI.Models.Dto;

namespace tunc.AuthAPI.Models.Dto
{
    public class LoginResponseDto
    {
        public UserDto User { get; set; }
        public string Token { get; set; }
    }
}
