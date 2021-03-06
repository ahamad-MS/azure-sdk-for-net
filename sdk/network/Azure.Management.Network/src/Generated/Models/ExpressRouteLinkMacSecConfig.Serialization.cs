// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ExpressRouteLinkMacSecConfig : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (CknSecretIdentifier != null)
            {
                writer.WritePropertyName("cknSecretIdentifier");
                writer.WriteStringValue(CknSecretIdentifier);
            }
            if (CakSecretIdentifier != null)
            {
                writer.WritePropertyName("cakSecretIdentifier");
                writer.WriteStringValue(CakSecretIdentifier);
            }
            if (Cipher != null)
            {
                writer.WritePropertyName("cipher");
                writer.WriteStringValue(Cipher.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ExpressRouteLinkMacSecConfig DeserializeExpressRouteLinkMacSecConfig(JsonElement element)
        {
            string cknSecretIdentifier = default;
            string cakSecretIdentifier = default;
            ExpressRouteLinkMacSecCipher? cipher = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cknSecretIdentifier"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cknSecretIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cakSecretIdentifier"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cakSecretIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cipher"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cipher = new ExpressRouteLinkMacSecCipher(property.Value.GetString());
                    continue;
                }
            }
            return new ExpressRouteLinkMacSecConfig(cknSecretIdentifier, cakSecretIdentifier, cipher);
        }
    }
}
