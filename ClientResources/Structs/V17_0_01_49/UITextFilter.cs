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

[StructSize(128)]
[XdbName("UITextFilter")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @UITextFilter
{
    [FieldOffset(40)] public WString @additionalChars;
    [FieldOffset(64)] public WString @firstChars;
    [FieldOffset(88, ArrayStride = 56)] public Layouts.@s_1bf7920[] @ranges;
    [FieldOffset(120)] public bool @isAllowObject;
}
