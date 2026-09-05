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

[SerializedExtent(136)]
[XdbName("AstralSpellProjectile")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @AstralSpellProjectile
{
    [FieldOffset(48)] public ResourcePointer @hullCrit;
    [FieldOffset(56)] public ResourcePointer @hullExplosion;
    [FieldOffset(64)] public string @locatorName;
    [FieldOffset(88)] public string @locatorTo;
    [FieldOffset(112)] public ResourcePointer @projectileFx;
    [FieldOffset(120)] public ResourcePointer @shieldCrit;
    [FieldOffset(128)] public ResourcePointer @shieldExplosion;
}
