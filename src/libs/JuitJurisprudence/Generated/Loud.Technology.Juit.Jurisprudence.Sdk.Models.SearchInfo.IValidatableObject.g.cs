#nullable enable

namespace Loud.Technology.Juit.Jurisprudence.Sdk
{
    public sealed partial class SearchInfo : global::System.ComponentModel.DataAnnotations.IValidatableObject
    {
        /// <inheritdoc />
        public global::System.Collections.Generic.IEnumerable<global::System.ComponentModel.DataAnnotations.ValidationResult> Validate(
            global::System.ComponentModel.DataAnnotations.ValidationContext validationContext)
        {
                        if (ElapsedTimeInMs.HasValue && ElapsedTimeInMs.Value < global::System.Int32.Parse("0", global::System.Globalization.CultureInfo.InvariantCulture))
            {
                yield return new global::System.ComponentModel.DataAnnotations.ValidationResult(
                    errorMessage: "Invalid value for ElapsedTimeInMs, must be a value greater than or equal to 0.",
                    memberNames: new[] { nameof(ElapsedTimeInMs) });
            }
        }
    }
}
