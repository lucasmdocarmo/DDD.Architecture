﻿namespace DDD.Shared.Core.Shared.Exceptions;

public class BusinessRuleException : Exception
{
    public BusinessRuleException(string message) : base(message) { }
}