// Koine.API/Settings/ClerkSettings.cs
namespace Koine.API.Settings;

/// <summary>
/// Configuration settings for Clerk JWT validation.
/// Bound from the <c>ClerkSettings</c> configuration section
/// (or <c>ClerkSettings__*</c> environment variables).
/// </summary>
/// <param name="JwksUrl">
/// The Clerk JWKS endpoint URL used to fetch signing keys.
/// Corresponds to <c>CLERK_JWKS_URL</c> / <c>ClerkSettings__JwksUrl</c>.
/// </param>
/// <param name="Issuer">
/// The Clerk Frontend API URL used to validate the <c>iss</c> claim.
/// Corresponds to <c>CLERK_ISSUER</c> / <c>ClerkSettings__Issuer</c>.
/// </param>
/// <param name="AuthorizedParties">
/// The allowed origins validated against the <c>azp</c> claim.
/// Corresponds to <c>CLERK_AUTHORIZED_PARTIES</c> / <c>ClerkSettings__AuthorizedParties</c>.
/// </param>
public record ClerkSettings(
    string JwksUrl,
    string Issuer,
    string[] AuthorizedParties
);
