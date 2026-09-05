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

[SerializedExtent(116)]
[XdbName("itemService.medal.observer.DressCollectionObserver")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @DressCollectionObserver
{
    [FieldOffset(40)] public TextFileRef @progressTitle;
    [FieldOffset(80, ArrayStride = 48)] public Layouts.@s_188e8e0[] @dressSlotObservers;
    [FieldOffset(112)][EnumRef(typeof(Enums.@e_fefe10))] public int @type;
}
