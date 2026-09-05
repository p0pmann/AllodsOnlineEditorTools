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

[SerializedExtent(120)]
[XdbName("EntityVisActionIfVisObject")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @EntityVisActionIfVisObject
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(80)] public NullablePointer @defaultVisAction;
    [FieldOffset(88, ArrayStride = 24)] public Layouts.@s_11b2e10[] @visObjectMatches;
}
