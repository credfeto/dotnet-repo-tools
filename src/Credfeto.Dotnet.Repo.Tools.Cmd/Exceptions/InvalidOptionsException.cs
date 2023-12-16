﻿using System;

namespace Credfeto.Dotnet.Repo.Tools.Cmd.Exceptions;

public sealed class InvalidOptionsException : Exception
{
    public InvalidOptionsException()
    {
    }

    public InvalidOptionsException(string? message)
        : base(message)
    {
    }

    public InvalidOptionsException(string? message, Exception? innerException)
        : base(message: message, innerException: innerException)
    {
    }
}