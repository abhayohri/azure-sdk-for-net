// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Search.Documents;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class AzureOpenAIParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceUri))
            {
                writer.WritePropertyName("resourceUri"u8);
                writer.WriteStringValue(ResourceUri.AbsoluteUri);
            }
            if (Optional.IsDefined(DeploymentId))
            {
                writer.WritePropertyName("deploymentId"u8);
                writer.WriteStringValue(DeploymentId);
            }
            if (Optional.IsDefined(ApiKey))
            {
                writer.WritePropertyName("apiKey"u8);
                writer.WriteStringValue(ApiKey);
            }
            if (Optional.IsDefined(AuthIdentity))
            {
                if (AuthIdentity != null)
                {
                    writer.WritePropertyName("authIdentity"u8);
                    writer.WriteObjectValue(AuthIdentity);
                }
                else
                {
                    writer.WriteNull("authIdentity");
                }
            }
            writer.WriteEndObject();
        }

        internal static AzureOpenAIParameters DeserializeAzureOpenAIParameters(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri resourceUri = default;
            string deploymentId = default;
            string apiKey = default;
            SearchIndexerDataIdentity authIdentity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deploymentId"u8))
                {
                    deploymentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiKey"u8))
                {
                    apiKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        authIdentity = null;
                        continue;
                    }
                    authIdentity = SearchIndexerDataIdentity.DeserializeSearchIndexerDataIdentity(property.Value);
                    continue;
                }
            }
            return new AzureOpenAIParameters(resourceUri, deploymentId, apiKey, authIdentity);
        }
    }
}
