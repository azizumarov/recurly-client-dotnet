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
    public class PerformanceObligation : Resource
    {

        /// <value>Created At</value>
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        /// <value>
        /// The ID of a performance obligation. Performance obligations are
        /// only accessible as a part of the Recurly RevRec Standard and
        /// Recurly RevRec Advanced features.
        /// </value>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <value>Performance Obligation Name</value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <value>Last updated at</value>
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

    }
}
