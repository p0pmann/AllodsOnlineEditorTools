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
[XdbName("TutorialCategoryResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @TutorialCategoryResource
{
    [FieldOffset(40)] public TextFileRef @name;
    [FieldOffset(72)] public string @sysName;
    [FieldOffset(96, ArrayStride = 8)] public ResourcePointer[] @tutorials;
    [FieldOffset(128)] public bool @isHidden;
}
