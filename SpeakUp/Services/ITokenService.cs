using SpeakUp.Models;

namespace SpeakUp.Services {
    public interface ITokenService {
        Task<string> GenerateToken(ApplicationUser user);
    }
}
