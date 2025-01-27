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
    public class BusinessEntity : Resource
    {

        /// <value>The entity code of the business entity.</value>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <value>Created at</value>
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        /// <value>
        /// The ID of a general ledger account. General ledger accounts are
        /// only accessible as a part of the Recurly RevRec Standard and
        /// Recurly RevRec Advanced features.
        /// </value>
        [JsonProperty("default_liability_gl_account_id")]
        public string DefaultLiabilityGlAccountId { get; set; }

        /// <value>Registration number for the customer used on the invoice.</value>
        [JsonProperty("default_registration_number")]
        public string DefaultRegistrationNumber { get; set; }

        /// <value>
        /// The ID of a general ledger account. General ledger accounts are
        /// only accessible as a part of the Recurly RevRec Standard and
        /// Recurly RevRec Advanced features.
        /// </value>
        [JsonProperty("default_revenue_gl_account_id")]
        public string DefaultRevenueGlAccountId { get; set; }

        /// <value>VAT number for the customer used on the invoice.</value>
        [JsonProperty("default_vat_number")]
        public string DefaultVatNumber { get; set; }

        /// <value>The source of the address that will be used as the destinaion in determining taxes. Available only when the site is on an Elite plan. A value of "destination" refers to the "Customer tax address". A value of "origin" refers to the "Business entity tax address".</value>
        [JsonProperty("destination_tax_address_source")]
        [JsonConverter(typeof(RecurlyStringEnumConverter))]
        public Constants.DestinationTaxAddressSource? DestinationTaxAddressSource { get; set; }

        /// <value>Business entity ID</value>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <value>Address information for the business entity that will appear on the invoice.</value>
        [JsonProperty("invoice_display_address")]
        public Address InvoiceDisplayAddress { get; set; }

        /// <value>This name describes your business entity and will appear on the invoice.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <value>Object type</value>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <value>The source of the address that will be used as the origin in determining taxes. Available only when the site is on an Elite plan. A value of "origin" refers to the "Business entity tax address". A value of "destination" refers to the "Customer tax address".</value>
        [JsonProperty("origin_tax_address_source")]
        [JsonConverter(typeof(RecurlyStringEnumConverter))]
        public Constants.OriginTaxAddressSource? OriginTaxAddressSource { get; set; }

        /// <value>List of countries for which the business entity will be used.</value>
        [JsonProperty("subscriber_location_countries")]
        public List<string> SubscriberLocationCountries { get; set; }

        /// <value>Address information for the business entity that will be used for calculating taxes.</value>
        [JsonProperty("tax_address")]
        public Address TaxAddress { get; set; }

        /// <value>Last updated at</value>
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

    }
}
