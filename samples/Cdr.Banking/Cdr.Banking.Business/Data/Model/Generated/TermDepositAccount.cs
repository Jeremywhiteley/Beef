/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable IDE0005 // Using directive is unnecessary; are required depending on code-gen options
#pragma warning disable CA2227, CA1819 // Collection/Array properties should be read only; ignored, as acceptable for a DTO.

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Beef.Entities;
using Newtonsoft.Json;

namespace Cdr.Banking.Business.Data.Model
{
    /// <summary>
    /// Represents the Term Deposit Account entity.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class TermDepositAccount
    {
        /// <summary>
        /// Gets or sets the Lodgement Date.
        /// </summary>
        [JsonProperty("lodgementDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime LodgementDate { get; set; }

        /// <summary>
        /// Gets or sets the Maturity Date.
        /// </summary>
        [JsonProperty("maturityDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime MaturityDate { get; set; }

        /// <summary>
        /// Gets or sets the Maturity Amount.
        /// </summary>
        [JsonProperty("maturityAmount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal MaturityAmount { get; set; }

        /// <summary>
        /// Gets or sets the Maturity Currency.
        /// </summary>
        [JsonProperty("maturityCurrency", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? MaturityCurrency { get; set; }

        /// <summary>
        /// Gets or sets the Maturity Instructions.
        /// </summary>
        [JsonProperty("maturityInstructions", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? MaturityInstructions { get; set; }
    } 
}

#pragma warning restore CA2227, CA1819
#pragma warning restore IDE0005
#nullable restore