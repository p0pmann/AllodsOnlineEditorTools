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

[StructSize(552)]
[XdbName("UIAddon")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @UIAddon
{
    [FieldOffset(40)] public ResourcePointer @Form;
    [FieldOffset(48)] public string @Name;
    [FieldOffset(72, ArrayStride = 40)] public FileRef[] @ScriptFileRefs;
    [FieldOffset(104)] public ResourcePointer @contentKey;
    [FieldOffset(112)] public ResourcePointer @excludeContentKey;
    [FieldOffset(120, ArrayStride = 40)] public Layouts.@s_1b18d60[] @resourcesGroups;
    [FieldOffset(152, ArrayStride = 40)] public Layouts.@s_1bd52e0[] @soundsGroups;
    [FieldOffset(184, ArrayStride = 8)] public ResourcePointer[] @styleSheets;
    [FieldOffset(216, ArrayStride = 40)] public Layouts.@s_1bd6990[] @textsGroups;
    [FieldOffset(248, ArrayStride = 40)] public Layouts.@s_1bd7c90[] @texturesGroups;
    [FieldOffset(280)] public Layouts.@s_1bc0a20 @userAddonInfo;
    [FieldOffset(512, ArrayStride = 40)] public Layouts.@s_1b1bb30[] @widgetGroups;
    [FieldOffset(544)] public bool @AutoStart;
    [FieldOffset(545)] public bool @Managed;
    [FieldOffset(546)] public bool @useCommonScripts;
}
