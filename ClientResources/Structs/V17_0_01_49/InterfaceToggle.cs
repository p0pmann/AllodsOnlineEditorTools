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

[SerializedExtent(52)]
[XdbName("InterfaceToggle")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @InterfaceToggle
{
    [FieldOffset(44)][EnumRef(typeof(Enums.@e_1014820))] public int @toggleTarget;
    [FieldOffset(48)] public bool @hide;
    [FieldOffset(49)] public bool @hideCursor;
    [FieldOffset(50)] public bool @lockInput;
    [FieldOffset(51)] public bool @useCinemaStripes;
}
