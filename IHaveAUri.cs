/*
 * IHaveAUri.cs
 *
 *   Created: 2023-03-13-05:50:24
 *   Modified: 2023-03-29-12:11:49
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */


namespace Dgmjr.Abstractions;

using System;

/// <summary>
/// Defines a mechanism for objects that have a read-only <see cref="System.Uri" />.
/// </summary>
public interface IHaveAUri
{
    /// <summary>
    /// Gets the URI of the object.
    /// </summary>
    Uri Uri { get; }
}

/// <summary>
/// Defines a mechanism for objects that have a writable URI.
/// </summary>
public interface IHaveAWritableUri : IHaveAUri
{
    /// <summary>
    /// Gets or sets the URI of the object.
    /// </summary>
    new Uri Uri { get; set; }
}
