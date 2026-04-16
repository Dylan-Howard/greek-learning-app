namespace Koine.Application.Common;

/// <summary>
/// Plain abstract root for all action classes.
/// Provides a common type for assembly scanning, DI registration,
/// and any future shared behaviour. Has no generic type parameters,
/// no injected dependencies, and no methods.
/// </summary>
public abstract class BaseAction { }
