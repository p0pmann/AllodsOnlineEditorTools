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

[StructSize(184)]
[XdbName("gameMechanics.mail.MailTemplate")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @MailTemplate
{
    [FieldOffset(40)] public TextFileRef @body;
    [FieldOffset(72)] public ResourcePointer @clientData;
    [FieldOffset(80)] public TextFileRef @from;
    [FieldOffset(112)] public TextFileRef @subject;
    [FieldOffset(144)] public string @sysName;
    [FieldOffset(168)] public ResourcePointer @voteResource;
    [FieldOffset(176)] public bool @denyRemoveMailWithItems;
}
