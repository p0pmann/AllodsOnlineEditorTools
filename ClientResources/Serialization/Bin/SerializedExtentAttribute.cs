namespace AllodsOnlineEditorTools.ClientResources.Serialization.Bin;

/// <summary>End of the last recovered serialized field, not the native allocation size.</summary>
[AttributeUsage(AttributeTargets.Class)]
public sealed class SerializedExtentAttribute(int size) : Attribute
{
    public int Size { get; } = size;
}
