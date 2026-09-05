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

[SerializedExtent(125)]
[XdbName("AstralSpellChanneling")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @AstralSpellChanneling
{
    [FieldOffset(44)] public float @fxLength;
    [FieldOffset(48)] public ResourcePointer @hullExplosion;
    [FieldOffset(56)] public string @locatorName;
    [FieldOffset(80)] public string @locatorTo;
    [FieldOffset(104)] public ResourcePointer @projectileFx;
    [FieldOffset(112)] public ResourcePointer @shieldExplosion;
    [FieldOffset(120)][EnumRef(typeof(Enums.@e_150c350))] public int @targetSettings;
    [FieldOffset(124)] public bool @ignoreShield;
}
