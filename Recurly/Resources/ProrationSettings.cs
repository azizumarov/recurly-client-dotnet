/**
 * This file is automatically created by Recurly's OpenAPI generation process
 * and thus any edits you make by hand will be lost. If you wish to make a
 * change to this file, please create a Github issue explaining the changes you
 * need and we will usher them to the appropriate places.
 */
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace Recurly.Resources
{
    [ExcludeFromCodeCoverage]
    public class ProrationSettings : Request
    {

        /// <value>Determines how the amount charged is determined for this change</value>
        [JsonProperty("charge")]
        [JsonConverter(typeof(RecurlyStringEnumConverter))]
        public Constants.ProrationSettingsCharge? Charge { get; set; }

        /// <value>Determines how the amount credited is determined for this change</value>
        [JsonProperty("credit")]
        [JsonConverter(typeof(RecurlyStringEnumConverter))]
        public Constants.ProrationSettingsCredit? Credit { get; set; }

    }
}
