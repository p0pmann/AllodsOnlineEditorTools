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

[SerializedExtent(120)]
[XdbName("itemService.medal.observer.MedalCollectionObserver")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @MedalCollectionObserver
{
    [FieldOffset(40)] public TextFileRef @progressTitle;
    [FieldOffset(88, ArrayStride = 8)] public ResourcePointer[] @medalCollection;
}
