/*
 * IHaveAGuidString.cs
 *
 *   Created: 2023-10-05-03:48:34
 *   Modified: 2023-10-05-03:48:56
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Abstractions;

using System;

/// <summary>
/// Defines a mechanism for objects that have a read-only <see cref="System.Guid" />.
/// </summary>
public interface IHaveAGuidString
{
    /// <summary>
    /// Gets the Guid of the object.
    /// </summary>
    string GuidString { get; }
}

/// <summary>
/// Defines a mechanism for objects that have a writable Guid.
/// </summary>
public interface IHaveAWritableGuidString : IHaveAGuidString
{
    /// <summary>
    /// Gets or sets the Guid of the object.
    /// </summary>
    new string GuidString { set; }
}
