/* 
 * IHaveAValue{TValue}.cs
 * 
 *   Created: 2023-03-13-05:50:24
 *   Modified: 2023-03-29-12:12:07
 * 
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *   
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Abstractions;

/// <summary>
/// Defines a mechanism for objects that have a read-only value of type <typeparamref name="TValue"/>.
/// </summary>
/// <typeparam name="TValue">The type of the value.</typeparam>
public interface IHaveAValue<TValue>
{
    /// <summary>
    /// Gets the value of the object.
    /// </summary>
    TValue Value { get; }
}

/// <summary>
/// Defines a mechanism for objects that have a writable value of type <typeparamref name="TValue"/>.
/// </summary>
/// <typeparam name="TValue">The type of the value.</typeparam>
public interface IHaveAWritableValue<TValue> : IHaveAValue<TValue>
{
    /// <summary>
    /// Gets or sets the value of the object.
    /// </summary>
    new TValue Value { set; }
}
