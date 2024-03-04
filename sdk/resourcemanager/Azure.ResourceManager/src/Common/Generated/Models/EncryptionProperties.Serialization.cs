// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Models
{
    [JsonConverter(typeof(EncryptionPropertiesConverter))]
    public partial class EncryptionProperties : IUtf8JsonSerializable, IJsonModel<EncryptionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EncryptionProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EncryptionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EncryptionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EncryptionProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(KeyVaultProperties))
            {
                writer.WritePropertyName("keyVaultProperties"u8);
                writer.WriteObjectValue(KeyVaultProperties);
            }
            writer.WriteEndObject();
        }

        EncryptionProperties IJsonModel<EncryptionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EncryptionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EncryptionProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEncryptionProperties(document.RootElement, options);
        }

        internal static EncryptionProperties DeserializeEncryptionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EncryptionStatus? status = default;
            KeyVaultProperties keyVaultProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new EncryptionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyVaultProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultProperties = KeyVaultProperties.DeserializeKeyVaultProperties(property.Value, options);
                    continue;
                }
            }
            return new EncryptionProperties(status, keyVaultProperties);
        }

        BinaryData IPersistableModel<EncryptionProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EncryptionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EncryptionProperties)} does not support '{options.Format}' format.");
            }
        }

        EncryptionProperties IPersistableModel<EncryptionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EncryptionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEncryptionProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EncryptionProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EncryptionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal partial class EncryptionPropertiesConverter : JsonConverter<EncryptionProperties>
        {
            public override void Write(Utf8JsonWriter writer, EncryptionProperties model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EncryptionProperties Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEncryptionProperties(document.RootElement);
            }
        }
    }
}
