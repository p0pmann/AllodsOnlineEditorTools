// Generated from client serializer evidence. Regenerate with EditorCLI generate structs.
// ReSharper disable InconsistentNaming
#nullable disable
using System.Numerics;
using AllodsOnlineEditorTools.ClientResources.DataTypes;
using AllodsOnlineEditorTools.ClientResources.Serialization;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin;
using AllodsOnlineEditorTools.ClientResources.Serialization.Xdb;
using JetBrains.Annotations;

namespace AllodsOnlineEditorTools.ClientResources.Structs.V17_0_01_49;

[SerializedExtent(81)]
[XdbName("VICOverride")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @VICOverride
{
    [FieldOffset(44)][EnumRef(typeof(Enums.@e_d13300))] public int @itemPriority;
    [FieldOffset(48, ArrayStride = 16)] public Layouts.@s_d10290[] @visItems;
    [FieldOffset(80)] public bool @cancelDefaultDressSlotSettings;
}
