// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.KeyVault;

namespace Azure.ResourceManager.KeyVault.Models
{
    public partial class IdentityAccessPermissions : IUtf8JsonSerializable, IJsonModel<IdentityAccessPermissions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IdentityAccessPermissions>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IdentityAccessPermissions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IdentityAccessPermissions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IdentityAccessPermissions)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Keys))
            {
                writer.WritePropertyName("keys"u8);
                writer.WriteStartArray();
                foreach (var item in Keys)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Secrets))
            {
                writer.WritePropertyName("secrets"u8);
                writer.WriteStartArray();
                foreach (var item in Secrets)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Certificates))
            {
                writer.WritePropertyName("certificates"u8);
                writer.WriteStartArray();
                foreach (var item in Certificates)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Storage))
            {
                writer.WritePropertyName("storage"u8);
                writer.WriteStartArray();
                foreach (var item in Storage)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
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

        IdentityAccessPermissions IJsonModel<IdentityAccessPermissions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IdentityAccessPermissions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IdentityAccessPermissions)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIdentityAccessPermissions(document.RootElement, options);
        }

        internal static IdentityAccessPermissions DeserializeIdentityAccessPermissions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<IdentityAccessKeyPermission> keys = default;
            IList<IdentityAccessSecretPermission> secrets = default;
            IList<IdentityAccessCertificatePermission> certificates = default;
            IList<IdentityAccessStoragePermission> storage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IdentityAccessKeyPermission> array = new List<IdentityAccessKeyPermission>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new IdentityAccessKeyPermission(item.GetString()));
                    }
                    keys = array;
                    continue;
                }
                if (property.NameEquals("secrets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IdentityAccessSecretPermission> array = new List<IdentityAccessSecretPermission>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new IdentityAccessSecretPermission(item.GetString()));
                    }
                    secrets = array;
                    continue;
                }
                if (property.NameEquals("certificates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IdentityAccessCertificatePermission> array = new List<IdentityAccessCertificatePermission>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new IdentityAccessCertificatePermission(item.GetString()));
                    }
                    certificates = array;
                    continue;
                }
                if (property.NameEquals("storage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IdentityAccessStoragePermission> array = new List<IdentityAccessStoragePermission>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new IdentityAccessStoragePermission(item.GetString()));
                    }
                    storage = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IdentityAccessPermissions(keys ?? new ChangeTrackingList<IdentityAccessKeyPermission>(), secrets ?? new ChangeTrackingList<IdentityAccessSecretPermission>(), certificates ?? new ChangeTrackingList<IdentityAccessCertificatePermission>(), storage ?? new ChangeTrackingList<IdentityAccessStoragePermission>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IdentityAccessPermissions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IdentityAccessPermissions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IdentityAccessPermissions)} does not support '{options.Format}' format.");
            }
        }

        IdentityAccessPermissions IPersistableModel<IdentityAccessPermissions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IdentityAccessPermissions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIdentityAccessPermissions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IdentityAccessPermissions)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IdentityAccessPermissions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
