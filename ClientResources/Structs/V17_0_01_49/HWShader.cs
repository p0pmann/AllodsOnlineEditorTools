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

[StructSize(128)]
[XdbName("HWShader")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @HWShader
{
    [FieldOffset(40)] public FileRef @binaryFile;
    [FieldOffset(80)] public Layouts.@s_2106e0 @blob;
    [FieldOffset(96, ArrayStride = 32)] public Layouts.@s_210b60[] @colorVars;
}
