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

[SerializedExtent(90)]
[XdbName("CameraDirectionAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CameraDirectionAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(68)] public Layouts.@s_fb9470 @pitch;
    [FieldOffset(80)] public Layouts.@s_fb9470 @yaw;
}
