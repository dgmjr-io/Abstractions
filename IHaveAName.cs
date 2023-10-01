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
/// Defines a mechanism for objects that have a read-only name.
/// </summary>
public interface IHaveAName
{
    /// <summary>
    /// Gets the name of the object.
    /// </summary>
    [FromString]
    string Name { get; }
}

/// <summary>
/// Defines a mechanism for objects that have a writable name.
/// </summary>
public interface IHaveAWritableName : IHaveAName
{
    /// <summary>
    /// Gets or sets the name of the object.
    /// </summary>
    [FromString]
    new string Name { set; }
}
