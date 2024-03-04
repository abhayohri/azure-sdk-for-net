// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    public partial class NetworkManagerDeploymentStatus : IUtf8JsonSerializable, IJsonModel<NetworkManagerDeploymentStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkManagerDeploymentStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkManagerDeploymentStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkManagerDeploymentStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkManagerDeploymentStatus)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CommitOn))
            {
                writer.WritePropertyName("commitTime"u8);
                writer.WriteStringValue(CommitOn.Value, "O");
            }
            if (Optional.IsDefined(Region))
            {
                writer.WritePropertyName("region"u8);
                writer.WriteStringValue(Region);
            }
            if (Optional.IsDefined(DeploymentState))
            {
                writer.WritePropertyName("deploymentStatus"u8);
                writer.WriteStringValue(DeploymentState.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ConfigurationIds))
            {
                writer.WritePropertyName("configurationIds"u8);
                writer.WriteStartArray();
                foreach (var item in ConfigurationIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DeploymentType))
            {
                writer.WritePropertyName("deploymentType"u8);
                writer.WriteStringValue(DeploymentType.Value.ToString());
            }
            if (Optional.IsDefined(ErrorMessage))
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        NetworkManagerDeploymentStatus IJsonModel<NetworkManagerDeploymentStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkManagerDeploymentStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkManagerDeploymentStatus)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkManagerDeploymentStatus(document.RootElement, options);
        }

        internal static NetworkManagerDeploymentStatus DeserializeNetworkManagerDeploymentStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? commitTime = default;
            string region = default;
            NetworkManagerDeploymentState? deploymentStatus = default;
            IReadOnlyList<string> configurationIds = default;
            NetworkConfigurationDeploymentType? deploymentType = default;
            string errorMessage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("commitTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    commitTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("region"u8))
                {
                    region = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deploymentStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deploymentStatus = new NetworkManagerDeploymentState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("configurationIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    configurationIds = array;
                    continue;
                }
                if (property.NameEquals("deploymentType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deploymentType = new NetworkConfigurationDeploymentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkManagerDeploymentStatus(
                commitTime,
                region,
                deploymentStatus,
                configurationIds ?? new ChangeTrackingList<string>(),
                deploymentType,
                errorMessage,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkManagerDeploymentStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkManagerDeploymentStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkManagerDeploymentStatus)} does not support '{options.Format}' format.");
            }
        }

        NetworkManagerDeploymentStatus IPersistableModel<NetworkManagerDeploymentStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkManagerDeploymentStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkManagerDeploymentStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkManagerDeploymentStatus)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkManagerDeploymentStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
