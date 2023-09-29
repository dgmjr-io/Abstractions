public interface IHaveAGuid
{
    guid Guid { get; }
}

public interface IHaveAWritableGuid : IHaveAGuid
{
    new guid Guid { set; }
}
