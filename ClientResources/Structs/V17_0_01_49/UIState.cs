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

[StructSize(272)]
[XdbName("UIState")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @UIState
{
    [FieldOffset(40, ArrayStride = 8)] public ResourcePointer[] @Addons;
    [FieldOffset(72)] public ResourcePointer @MainAddon;
    [FieldOffset(80)] public ResourcePointer @MainForm;
    [FieldOffset(88)] public string @Name;
    [FieldOffset(112, ArrayStride = 40)] public Layouts.@s_1b18d60[] @resourcesGroups;
    [FieldOffset(144, ArrayStride = 40)] public Layouts.@s_1bd52e0[] @soundsGroups;
    [FieldOffset(176, ArrayStride = 40)] public Layouts.@s_1bd6990[] @textsGroups;
    [FieldOffset(208, ArrayStride = 40)] public Layouts.@s_1bd7c90[] @texturesGroups;
    [FieldOffset(240, ArrayStride = 40)] public Layouts.@s_1b1bb30[] @widgetGroups;
}
