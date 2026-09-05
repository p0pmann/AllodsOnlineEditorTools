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

[StructSize(72)]
[XdbName("Notifications")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @Notifications
{
    [FieldOffset(40)] public ResourcePointer @GuildCannotHaveSymbolics;
    [FieldOffset(48)] public ResourcePointer @HasNoRight;
    [FieldOffset(56)] public ResourcePointer @ItemCannotUpdateSymbolics;
    [FieldOffset(64)] public ResourcePointer @NotInGuild;
}
