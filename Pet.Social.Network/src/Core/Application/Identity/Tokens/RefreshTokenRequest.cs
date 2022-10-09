namespace Pet.Social.Network.Application.Identity.Tokens;

public record RefreshTokenRequest(string Token, string RefreshToken);