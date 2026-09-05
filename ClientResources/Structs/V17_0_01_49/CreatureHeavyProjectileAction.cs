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
[XdbName("CreatureHeavyProjectileAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CreatureHeavyProjectileAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(72)] public string @fromLocator;
    [FieldOffset(96)] public ResourcePointer @hullCrit;
    [FieldOffset(104)] public ResourcePointer @hullExplosion;
    [FieldOffset(112)] public ResourcePointer @projectileFx;
    [FieldOffset(120)] public ResourcePointer @shieldCrit;
    [FieldOffset(128)] public ResourcePointer @shieldExplosion;
}
