/*
 * IHaveAValue.cs
 *
 *   Created: 2023-03-13-05:50:24
 *   Modified: 2023-03-29-12:11:57
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Abstractions;

/// <summary>
/// Defines a mechanism for objects that have a read-only value.
/// </summary>
public interface IHaveAValue
{
    /// <summary>
    /// Gets the value of the object.
    /// </summary>
    object Value { get; }
}

/// <summary>
/// Defines a mechanism for objects that have a writable value.
/// </summary>
public interface IHaveAWritableValue : IHaveAValue
{
    /// <summary>
    /// Gets or sets the value of the object.
    /// </summary>
    new object Value { get; set; }
}
