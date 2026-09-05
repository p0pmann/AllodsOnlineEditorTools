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

[StructSize(528)]
[XdbName("socialNetworks.SocialNetworkDescription")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @SocialNetworkDescription
{
    [FieldOffset(40)] public Layouts.@s_18ba8b0 @abilities;
    [FieldOffset(64)] public TextFileRef @displayName;
    [FieldOffset(96)] public ResourcePointer @image;
    [FieldOffset(104)] public ResourcePointer @imageSmall;
    [FieldOffset(112, ArrayStride = 88)] public Layouts.@s_18bac50[] @postStyles;
    [FieldOffset(144)] public Layouts.@s_18c2650 @script;
    [FieldOffset(224)] public Layouts.@s_18c2650 @scriptLocalization;
    [FieldOffset(304)] public Layouts.@s_18c2650 @scriptLocalizationTest;
    [FieldOffset(384)] public string @shortName;
    [FieldOffset(408)] public Layouts.@s_18bad50 @style;
    [FieldOffset(520)] public bool @excluded;
}
