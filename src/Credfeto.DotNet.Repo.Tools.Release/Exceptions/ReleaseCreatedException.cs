using System;

namespace Credfeto.DotNet.Repo.Tools.Release.Exceptions;

public sealed class ReleaseCreatedException : Exception
{
    public ReleaseCreatedException()
    {
    }

    public ReleaseCreatedException(string? message)
        : base(message)
    {
    }

    public ReleaseCreatedException(string? message, Exception? innerException)
        : base(message: message, innerException: innerException)
    {
    }
}