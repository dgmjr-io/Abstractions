using System.Runtime.InteropServices;

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
/// Defines a mechanism for objects that have synonyms.
/// </summary>
public interface IHaveSynonyms
{
    /// <summary>
    /// Gets the synonyms of the object.
    /// </summary>
    string[] Synonyms { get; init; }
}
