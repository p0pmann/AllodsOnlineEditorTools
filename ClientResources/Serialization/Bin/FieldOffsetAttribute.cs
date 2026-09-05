namespace AllodsOnlineEditorTools.ClientResources.Serialization.Bin;

[AttributeUsage(AttributeTargets.Field)]
public class FieldOffsetAttribute(int offset) : Attribute
{
    public int Offset { get; } = offset;
    public bool EmbeddedVirtual { get; init; }
    public int ArrayStride { get; set; }
}
