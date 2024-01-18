/*
 * IHaveAnEnumValue.cs
 *
 *   Created: 2024-08-16T07:08:02-05:00
 *   Modified: 2024-08-16T07:08:02-05:00
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2024 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Dgmjr.Abstractions;

public interface IHaveAnEnumValue
{
    System.Enum EnumValue { get; }
}

public interface IHaveAnEnumValue<TEnum> : IHaveAnEnumValue
    where TEnum : System.Enum
{
    new TEnum EnumValue { get; }
}

public interface IHaveAWritableEnumValue : IHaveAnEnumValue
{
    new System.Enum EnumValue { get; set; }
}

public interface IHaveAWritableEnumValue<TEnum> : IHaveAWritableEnumValue, IHaveAnEnumValue<TEnum>
    where TEnum : System.Enum
{
    new TEnum EnumValue { get; set; }
}
