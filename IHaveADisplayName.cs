/*
 * IHaveADescription.cs
 *
 *   Created: 2023-03-13-05:50:24
 *   Modified: 2023-03-29-12:11:23
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Abstractions;

/// <summary>
/// Marker interface for an object or struct that has a *read-only*
/// <c><see cref="DisplayName" /></c> property.
/// </summary>
public interface IHaveADisplayName
{
    /// <summary>
    /// The thing's display name
    /// </summary>
    string DisplayName { get; }
}

/// <summary>
/// Marker interface for an object or struct that has a *read/write*
/// <c><see cref="DisplayName" /></c> property.
/// </summary>
public interface IHaveAWritableDisplayName : IHaveADisplayName
{
    /// <summary>
    /// The thing's display name
    /// </summary>
    new string DisplayName { get; set; }
}
