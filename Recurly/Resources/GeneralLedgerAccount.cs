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
    public class GeneralLedgerAccount : Resource
    {


        [JsonProperty("account_type")]
        [JsonConverter(typeof(RecurlyStringEnumConverter))]
        public Constants.GeneralLedgerAccountType? AccountType { get; set; }

        /// <value>
        /// Unique code to identify the ledger account. Each code must start
        /// with a letter or number. The following special characters are
        /// allowed: `-_.,:`
        /// </value>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <value>Created at</value>
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        /// <value>Optional description.</value>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <value>
        /// The ID of a general ledger account. General ledger accounts are
        /// only accessible as a part of the Recurly RevRec Standard and
        /// Recurly RevRec Advanced features.
        /// </value>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <value>Object type</value>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <value>Last updated at</value>
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

    }
}
