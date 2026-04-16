namespace Koine.Application.Common.Exceptions;

/// <summary>
/// Thrown when one or more input DTO fields fail validation.
/// Carries field-level error details for HTTP 400 and GraphQL VALIDATION_ERROR responses.
/// </summary>
public class ValidationException : Exception
{
    /// <summary>
    /// Field-level validation errors keyed by field name.
    /// Each entry contains one or more error messages for that field.
    /// </summary>
    public IReadOnlyDictionary<string, string[]> Errors { get; }

    /// <summary>
    /// Initialises a <see cref="ValidationException"/> for a single field error.
    /// </summary>
    /// <param name="field">The name of the field that failed validation.</param>
    /// <param name="message">A human-readable description of the validation failure.</param>
    public ValidationException(string field, string message)
        : base($"Validation failed: {field} — {message}")
    {
        Errors = new Dictionary<string, string[]> { [field] = [message] };
    }

    /// <summary>
    /// Initialises a <see cref="ValidationException"/> with a pre-built errors dictionary.
    /// </summary>
    /// <param name="errors">A dictionary mapping field names to their validation error messages.</param>
    public ValidationException(IReadOnlyDictionary<string, string[]> errors)
        : base("One or more validation errors occurred.")
    {
        Errors = errors;
    }
}
