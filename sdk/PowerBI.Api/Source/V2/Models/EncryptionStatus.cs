// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for EncryptionStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EncryptionStatus
    {
        /// <summary>
        /// Unable to determine state due to dataset corruption
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,
        /// <summary>
        /// Encryption is not supported for this dataset
        /// </summary>
        [EnumMember(Value = "NotSupported")]
        NotSupported,
        /// <summary>
        /// Encryption is supported and is in sync with the encryption settings
        /// </summary>
        [EnumMember(Value = "InSyncWithWorkspace")]
        InSyncWithWorkspace,
        /// <summary>
        /// Encryption is supported and not in sync with the encryption
        /// settings
        /// </summary>
        [EnumMember(Value = "NotInSyncWithWorkspace")]
        NotInSyncWithWorkspace
    }
    internal static class EncryptionStatusEnumExtension
    {
        internal static string ToSerializedValue(this EncryptionStatus? value)
        {
            return value == null ? null : ((EncryptionStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this EncryptionStatus value)
        {
            switch( value )
            {
                case EncryptionStatus.Unknown:
                    return "Unknown";
                case EncryptionStatus.NotSupported:
                    return "NotSupported";
                case EncryptionStatus.InSyncWithWorkspace:
                    return "InSyncWithWorkspace";
                case EncryptionStatus.NotInSyncWithWorkspace:
                    return "NotInSyncWithWorkspace";
            }
            return null;
        }

        internal static EncryptionStatus? ParseEncryptionStatus(this string value)
        {
            switch( value )
            {
                case "Unknown":
                    return EncryptionStatus.Unknown;
                case "NotSupported":
                    return EncryptionStatus.NotSupported;
                case "InSyncWithWorkspace":
                    return EncryptionStatus.InSyncWithWorkspace;
                case "NotInSyncWithWorkspace":
                    return EncryptionStatus.NotInSyncWithWorkspace;
            }
            return null;
        }
    }
}
