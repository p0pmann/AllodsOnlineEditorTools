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

[StructSize(160)]
[XdbName("gameMechanics.constructor.schemes.unlock.UnlockResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @UnlockResource
{
    [FieldOffset(36)][EnumRef(typeof(Enums.@e_153c450))] public int @binding;
    [FieldOffset(40)] public ResourcePointer @category;
    [FieldOffset(48)] public TextFileRef @description;
    [FieldOffset(80)] public ResourcePointer @image;
    [FieldOffset(88)] public TextFileRef @name;
    [FieldOffset(120)] public ResourcePointer @sourceDescription;
    [FieldOffset(128)] public string @sysUIScriptName;
    [FieldOffset(152)] public bool @isHidden;
}
