/*
 * IHaveAName.cs
 *
 *   Created: 2023-03-13-05:50:24
 *   Modified: 2023-03-29-12:11:32
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Abstractions;

using System.ComponentModel.DataAnnotations;

/// <summary>
/// Defines a mechanism for objects that have a read-only short name.
/// </summary>
public interface IHaveAShortName
{
    /// <summary>
    /// Gets the name of the object.
    /// </summary>
    [FromString]
    string ShortName { get; }
}

/// <summary>
/// Defines a mechanism for objects that have a writable short name.
/// </summary>
public interface IHaveAWritableShortName : IHaveAShortName
{
    /// <summary>
    /// Gets or sets the short name of the object.
    /// </summary>
    [FromString]
    new string ShortName { set; }
}
