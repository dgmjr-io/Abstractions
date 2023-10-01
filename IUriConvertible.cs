/*
 * IUriConvertible.cs
 *
 *   Created: 2023-06-08-02:02:45
 *   Modified: 2023-06-08-02:02:53
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Abstractions;

#if NET7_0_OR_GREATER
/// <summary>
/// Defines a mechanism for objects that can be converted to and from a URI.
/// </summary>
/// <typeparam name="TSelf">The type that can be converted from a URI</typeparam>
public interface IUriConvertible<TSelf>
    where TSelf : IUriConvertible<TSelf>
{
    /// <summary>
    /// Converts the object from a URI.
    /// </summary>
    /// <param name="s">The URI as a string</param>
    /// <returns>An instance of <typeparamref name="TSelf" /></returns>
    public static abstract IUriConvertible<TSelf> FromUri(string s);

    /// <summary>
    /// Converts the object from a URI.
    /// </summary>
    /// <param name="uri">The URI</param>
    /// <returns>An instance of <typeparamref name="TSelf" /></returns>
    public static virtual IUriConvertible<TSelf> FromUri(Uri uri) => TSelf.FromUri(uri.ToString());
}
#endif
