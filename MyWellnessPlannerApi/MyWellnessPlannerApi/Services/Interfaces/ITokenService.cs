namespace MyWellnessPlannerApi.Services.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(string username);
    }
}
