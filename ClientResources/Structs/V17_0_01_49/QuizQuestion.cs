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

[SerializedExtent(92)]
[XdbName("QuizQuestion")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @QuizQuestion
{
    [FieldOffset(48)] public ResourcePointer @image;
    [FieldOffset(56)] public TextFileRef @text;
    [FieldOffset(88)][EnumRef(typeof(Enums.@e_1127e80))] public int @type;
}
