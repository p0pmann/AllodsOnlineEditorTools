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

[StructSize(200)]
[XdbName("SceneSettings")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @SceneSettings
{
    [FieldOffset(40)] public ResourcePointer @areaEffect;
    [FieldOffset(48)] public ResourcePointer @postEffectParams;
    [FieldOffset(56)] public ResourcePointer @skyMesh;
    [FieldOffset(64)] public Layouts.@s_a718e0 @staticLight;
}
