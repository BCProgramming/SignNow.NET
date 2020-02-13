using Newtonsoft.Json;

namespace SignNow.Net.Internal.Model
{
    /// <summary>
    /// SignNow fields metadata.
    /// </summary>
    internal class Field
    {
        /// <summary>
        /// Unique identifier of field.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// <see cref="SignNow.Net.Model.Role"/> identity.
        /// </summary>
        /// TODO: Use Role model instead of RoleId + RoleName
        [JsonProperty("role_id")]
        public string RoleId { get; set; }

        /// <summary>
        /// Signer role name.
        /// </summary>
        [JsonProperty("role")]
        public string RoleName { get; set; }

        /// <summary>
        /// Document owner email.
        /// </summary>
        [JsonProperty("originator")]
        public string Owner { get; set; }

        /// <summary>
        /// Signer email.
        /// </summary>
        [JsonProperty("fulfiller")]
        public string Signer { get; set; }
    }
}
