// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The content type of a source control path. </summary>
    public readonly partial struct ContentType : IEquatable<ContentType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContentType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContentType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AnalyticRuleValue = "AnalyticRule";
        private const string WorkbookValue = "Workbook";

        /// <summary> AnalyticRule. </summary>
        public static ContentType AnalyticRule { get; } = new ContentType(AnalyticRuleValue);
        /// <summary> Workbook. </summary>
        public static ContentType Workbook { get; } = new ContentType(WorkbookValue);
        /// <summary> Determines if two <see cref="ContentType"/> values are the same. </summary>
        public static bool operator ==(ContentType left, ContentType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContentType"/> values are not the same. </summary>
        public static bool operator !=(ContentType left, ContentType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContentType"/>. </summary>
        public static implicit operator ContentType(string value) => new ContentType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContentType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContentType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
