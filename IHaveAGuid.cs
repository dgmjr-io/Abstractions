namespace Dgmjr.Abstractions;

public interface IHaveAGuid
{
    guid Guid { get; }
}

public interface IHaveAWritableGuid : IHaveAGuid
{
    new guid Guid { get; set; }
}
