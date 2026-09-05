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

[StructSize(344)]
[XdbName("WebRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @WebRoot
{
    [FieldOffset(40)] public string @acceptLanguage;
    [FieldOffset(64)] public WString @contentKey;
    [FieldOffset(88)] public Layouts.@s_18c2650 @dataReceiverScript;
    [FieldOffset(168)] public Layouts.@s_18c2650 @fileReceiverScript;
    [FieldOffset(248)] public Layouts.@s_18c2650 @imageBrowserScript;
    [FieldOffset(328)] public ResourcePointer @namedWebResourcesRegistry;
    [FieldOffset(336)] public ResourcePointer @webCommonRegistry;
}
