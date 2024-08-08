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
    public class LineItemRefund : Request
    {

        /// <value>The specific amount to be refunded from the adjustment. Must be less than or equal to the adjustment's remaining balance. If `quantity`, `quantity_decimal` and `percentage` are not present, `amount` is required. If `quantity`, `quantity_decimal`, or `percentage` is present, `amount` must be absent.</value>
        [JsonProperty("amount")]
        public decimal? Amount { get; set; }

        /// <value>Line item ID</value>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <value>The percentage of the adjustment's remaining balance to refund. If `quantity`, `quantity_decimal` and `amount_in_cents` are not present, `percentage` is required. If `quantity`, `quantity_decimal` or `amount_in_cents` is present, `percentage` must be absent.</value>
        [JsonProperty("percentage")]
        public int? Percentage { get; set; }

        /// <value>
        /// Set to `true` if the line item should be prorated; set to `false` if not.
        /// This can only be used on line items that have a start and end date.
        /// </value>
        [JsonProperty("prorate")]
        public bool? Prorate { get; set; }

        /// <value>Line item quantity to be refunded. Must be less than or equal to the `quantity_remaining`. If `quantity_decimal`, `amount`, and `percentage` are not present, `quantity` is required. If `amount` or `percentage` is present, `quantity` must be absent.</value>
        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        /// <value>Decimal quantity to refund. The `quantity_decimal` will be used to refund charges that has a NOT null quantity decimal. Must be less than or equal to the `quantity_decimal_remaining`. If `quantity`, `amount`, and `percentage` are not present, `quantity_decimal` is required. If `amount` or `percentage` is present, `quantity_decimal` must be absent. The Decimal Quantity feature must be enabled to utilize this field.</value>
        [JsonProperty("quantity_decimal")]
        public string QuantityDecimal { get; set; }

    }
}
