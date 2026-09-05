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

[StructSize(184)]
[XdbName("ExtendedSound")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ExtendedSound
{
    [FieldOffset(40, ArrayStride = 4)] public int[] @boundIndices;
    [FieldOffset(72, ArrayStride = 24)] public BigVector3[] @boundPoints;
    [FieldOffset(104)] public Layouts.@s_a96bc0 @centralSound;
    [FieldOffset(144)] public Layouts.@s_a96d80 @sideSound;
}
