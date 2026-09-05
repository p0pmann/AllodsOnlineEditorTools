// Generated from client serializer evidence. Regenerate with EditorCLI generate structs.
// ReSharper disable InconsistentNaming
#nullable disable
using System.Numerics;
using AllodsOnlineEditorTools.ClientResources.DataTypes;
using AllodsOnlineEditorTools.ClientResources.Serialization;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin;
using AllodsOnlineEditorTools.ClientResources.Serialization.Xdb;
using JetBrains.Annotations;

namespace AllodsOnlineEditorTools.ClientResources.Structs.V17_0_01_49.Layouts;

[SerializedExtent(35)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_ac4100
{
    [FieldOffset(4)][EnumRef(typeof(Enums.@e_ac4610))] public int @blendEffect;
    [FieldOffset(8)] public Layouts.@s_ac3c50 @cutoutEffect;
    [FieldOffset(32)] public bool @useAlpha;
    [FieldOffset(33)] public bool @useRGB;
    [FieldOffset(34)] public bool @useUVDistortion;
}
