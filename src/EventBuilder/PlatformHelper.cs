﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace EventBuilder
{
    /// <summary>
    /// Platform helper methods.
    /// </summary>
    public static class PlatformHelper
    {
        private static readonly Lazy<bool> _IsRunningOnMono = new Lazy<bool>(() => Type.GetType("Mono.Runtime") != null);

        /// <summary>
        /// Determines whether the platform is running on mono.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is running on mono]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsRunningOnMono()
        {
            return _IsRunningOnMono.Value;
        }
    }
}
