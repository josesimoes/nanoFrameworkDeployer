﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace nanoFrameworkFlasher.Helpers
{
    /// <summary>
    /// Helper methods to write messages to the console.
    /// </summary>
    public class MessageHelper
    {
        private readonly CommandlineOptions options;

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageHelper"/> class.
        /// </summary>
        /// <param name="options">Command line options.</param>
        public MessageHelper(CommandlineOptions options)
        {
            this.options = options;
        }

        /// <summary>
        /// Helper method for verbose messages.
        /// </summary>
        /// <param name="message">Message to show in verbose mode.</param>
        public void Output(string message)
        {
            Console.WriteLine(message);
        }

        /// <summary>
        /// Helper method for verbose messages.
        /// </summary>
        /// <param name="message">Message to show in verbose mode.</param>
        public void Verbose(string message)
        {
            if (this.options == null || this.options.Verbose)
            {
                Console.WriteLine(message);
            }
        }

        /// <summary>
        /// Helper method for warning messages.
        /// </summary>
        /// <param name="message">Message to show in verbose mode.</param>
        public void Warning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        /// <summary>
        /// Helper method for error messages.
        /// </summary>
        /// <param name="message">Message to show in verbose mode.</param>
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
