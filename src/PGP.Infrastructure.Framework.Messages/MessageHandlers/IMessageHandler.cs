﻿using System;

namespace PGP.Infrastructure.Framework.Messages.MessageHandlers
{
    public interface IMessageHandler
    {
        /// <summary>
        /// Gets the message from code.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <returns></returns>
        string GetMessageFromCode(int code);

        /// <summary>
        /// Gets the message from enum.
        /// </summary>
        /// <param name="enumCode">The enum code.</param>
        /// <returns></returns>
        string GetMessageFromEnum(Enum enumCode);

        /// <summary>
        /// Gets the error from code.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <returns></returns>
        ErrorContent GetErrorFromCode(int code);

        /// <summary>
        /// Gets the error from enum.
        /// </summary>
        /// <param name="enumCode">The enum code.</param>
        /// <returns></returns>
        ErrorContent GetErrorFromEnum(Enum enumCode);

        /// <summary>
        /// Gets the generic error code.
        /// </summary>
        /// <returns></returns>
        int GetGenericErrorCode();
    }
}