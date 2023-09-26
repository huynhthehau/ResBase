using RestaurantManager.Application.Common.Interfaces.Authentication;

namespace RestaurantManager.Application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;

        public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
        {
            this._jwtTokenGenerator = jwtTokenGenerator;
        }
        public AuthenticationResult Login(string email, string password)
        {
            return new AuthenticationResult(Guid.NewGuid(), "firstName", "lastName", "Email", "Token");
        }

        public AuthenticationResult Register(string firstName, string lastName, string email, string password)
        {
            var userId = Guid.NewGuid();
            var token = _jwtTokenGenerator.GenerateToken(userId);
            return new AuthenticationResult(Guid.NewGuid(), "firstName", "lastName", "Email", token);
        }
    }
}
