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

[StructSize(104)]
[XdbName("itemService.rewardsExchange.TierResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @TierResource
{
    [FieldOffset(40)] public ResourcePointer @avatarUnlock;
    [FieldOffset(48)] public TextFileRef @name;
    [FieldOffset(80)] public ResourcePointer @quality;
    [FieldOffset(88)] public ResourcePointer @serverVariable;
    [FieldOffset(96)] public long @serverVariableValueGE;
}
