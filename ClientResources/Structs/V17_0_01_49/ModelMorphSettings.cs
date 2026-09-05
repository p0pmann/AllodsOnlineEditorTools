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

[StructSize(136)]
[XdbName("ModelMorphSettings")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ModelMorphSettings
{
    [FieldOffset(40, ArrayStride = 56)] public Layouts.@s_cb6940[] @controls;
    [FieldOffset(72, ArrayStride = 4)] public float[] @extScales;
    [FieldOffset(104, ArrayStride = 48)] public Layouts.@s_c64bc0[] @presets;
}
