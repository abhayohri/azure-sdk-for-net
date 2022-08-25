// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class MicrosoftSecurityIncidentCreationAlertRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(DisplayNamesFilter))
            {
                writer.WritePropertyName("displayNamesFilter");
                writer.WriteStartArray();
                foreach (var item in DisplayNamesFilter)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DisplayNamesExcludeFilter))
            {
                writer.WritePropertyName("displayNamesExcludeFilter");
                writer.WriteStartArray();
                foreach (var item in DisplayNamesExcludeFilter)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ProductFilter))
            {
                writer.WritePropertyName("productFilter");
                writer.WriteStringValue(ProductFilter.Value.ToString());
            }
            if (Optional.IsCollectionDefined(SeveritiesFilter))
            {
                writer.WritePropertyName("severitiesFilter");
                writer.WriteStartArray();
                foreach (var item in SeveritiesFilter)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AlertRuleTemplateName))
            {
                writer.WritePropertyName("alertRuleTemplateName");
                writer.WriteStringValue(AlertRuleTemplateName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(Enabled.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static MicrosoftSecurityIncidentCreationAlertRule DeserializeMicrosoftSecurityIncidentCreationAlertRule(JsonElement element)
        {
            AlertRuleKind kind = default;
            Optional<ETag> etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IList<string>> displayNamesFilter = default;
            Optional<IList<string>> displayNamesExcludeFilter = default;
            Optional<MicrosoftSecurityProductName> productFilter = default;
            Optional<IList<AlertSeverity>> severitiesFilter = default;
            Optional<string> alertRuleTemplateName = default;
            Optional<string> description = default;
            Optional<string> displayName = default;
            Optional<bool> enabled = default;
            Optional<DateTimeOffset> lastModifiedUtc = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = new AlertRuleKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("displayNamesFilter"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            displayNamesFilter = array;
                            continue;
                        }
                        if (property0.NameEquals("displayNamesExcludeFilter"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            displayNamesExcludeFilter = array;
                            continue;
                        }
                        if (property0.NameEquals("productFilter"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            productFilter = new MicrosoftSecurityProductName(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("severitiesFilter"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<AlertSeverity> array = new List<AlertSeverity>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new AlertSeverity(item.GetString()));
                            }
                            severitiesFilter = array;
                            continue;
                        }
                        if (property0.NameEquals("alertRuleTemplateName"))
                        {
                            alertRuleTemplateName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedUtc"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastModifiedUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new MicrosoftSecurityIncidentCreationAlertRule(id, name, type, systemData.Value, kind, Optional.ToNullable(etag), Optional.ToList(displayNamesFilter), Optional.ToList(displayNamesExcludeFilter), Optional.ToNullable(productFilter), Optional.ToList(severitiesFilter), alertRuleTemplateName.Value, description.Value, displayName.Value, Optional.ToNullable(enabled), Optional.ToNullable(lastModifiedUtc));
        }
    }
}
