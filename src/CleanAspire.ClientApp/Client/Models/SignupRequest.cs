// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace CleanAspire.Api.Client.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class SignupRequest : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>User&apos;s email address. Must be in a valid email format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>User&apos;s preferred language code, e.g., &apos;en-US&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LanguageCode { get; set; }
#nullable restore
#else
        public string LanguageCode { get; set; }
#endif
        /// <summary>User&apos;s preferred nickname.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Nickname { get; set; }
#nullable restore
#else
        public string Nickname { get; set; }
#endif
        /// <summary>User&apos;s password. Must meet the security criteria.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Password { get; set; }
#nullable restore
#else
        public string Password { get; set; }
#endif
        /// <summary>Authentication provider, e.g., Local or Google.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Provider { get; set; }
#nullable restore
#else
        public string Provider { get; set; }
#endif
        /// <summary>Tenant identifier for multi-tenant systems. Must be a GUID in version 7 format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId { get; set; }
#nullable restore
#else
        public string TenantId { get; set; }
#endif
        /// <summary>User&apos;s time zone identifier, e.g., &apos;UTC&apos;, &apos;America/New_York&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TimeZoneId { get; set; }
#nullable restore
#else
        public string TimeZoneId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::CleanAspire.Api.Client.Models.SignupRequest"/> and sets the default values.
        /// </summary>
        public SignupRequest()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::CleanAspire.Api.Client.Models.SignupRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::CleanAspire.Api.Client.Models.SignupRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::CleanAspire.Api.Client.Models.SignupRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "email", n => { Email = n.GetStringValue(); } },
                { "languageCode", n => { LanguageCode = n.GetStringValue(); } },
                { "nickname", n => { Nickname = n.GetStringValue(); } },
                { "password", n => { Password = n.GetStringValue(); } },
                { "provider", n => { Provider = n.GetStringValue(); } },
                { "tenantId", n => { TenantId = n.GetStringValue(); } },
                { "timeZoneId", n => { TimeZoneId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("languageCode", LanguageCode);
            writer.WriteStringValue("nickname", Nickname);
            writer.WriteStringValue("password", Password);
            writer.WriteStringValue("provider", Provider);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("timeZoneId", TimeZoneId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
