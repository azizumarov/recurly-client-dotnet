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
    public class BillingInfoCreate : Request
    {

        /// <value>The bank account number. (ACH, Bacs only)</value>
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        /// <value>The bank account type. (ACH only)</value>
        [JsonProperty("account_type")]
        public string AccountType { get; set; }


        [JsonProperty("address")]
        public Address Address { get; set; }

        /// <value>Amazon billing agreement ID</value>
        [JsonProperty("amazon_billing_agreement_id")]
        public string AmazonBillingAgreementId { get; set; }

        /// <value>Company name</value>
        [JsonProperty("company")]
        public string Company { get; set; }

        /// <value>*STRONGLY RECOMMENDED*</value>
        [JsonProperty("cvv")]
        public string Cvv { get; set; }

        /// <value>First name</value>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <value>Fraud Session ID</value>
        [JsonProperty("fraud_session_id")]
        public string FraudSessionId { get; set; }

        /// <value>An identifier for a specific payment gateway. Must be used in conjunction with `gateway_token`.</value>
        [JsonProperty("gateway_code")]
        public string GatewayCode { get; set; }

        /// <value>A token used in place of a credit card in order to perform transactions. Must be used in conjunction with `gateway_code`.</value>
        [JsonProperty("gateway_token")]
        public string GatewayToken { get; set; }

        /// <value>The International Bank Account Number, up to 34 alphanumeric characters comprising a country code; two check digits; and a number that includes the domestic bank account number, branch identifier, and potential routing information. (SEPA only)</value>
        [JsonProperty("iban")]
        public string Iban { get; set; }

        /// <value>*STRONGLY RECOMMENDED* Customer's IP address when updating their billing information.</value>
        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        /// <value>Last name</value>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <value>Expiration month</value>
        [JsonProperty("month")]
        public string Month { get; set; }

        /// <value>The name associated with the bank account (ACH, SEPA, Bacs only)</value>
        [JsonProperty("name_on_account")]
        public string NameOnAccount { get; set; }

        /// <value>Credit card number, spaces and dashes are accepted.</value>
        [JsonProperty("number")]
        public string Number { get; set; }

        /// <value>PayPal billing agreement ID</value>
        [JsonProperty("paypal_billing_agreement_id")]
        public string PaypalBillingAgreementId { get; set; }

        /// <value>A token generated by Recurly.js after completing a 3-D Secure device fingerprinting or authentication challenge.</value>
        [JsonProperty("three_d_secure_action_result_token_id")]
        public string ThreeDSecureActionResultTokenId { get; set; }

        /// <value>A token [generated by Recurly.js](https://docs.recurly.com/js/#getting-a-token).</value>
        [JsonProperty("token_id")]
        public string TokenId { get; set; }

        /// <value>An optional type designation for the payment gateway transaction created by this request. Supports 'moto' value, which is the acronym for mail order and telephone transactions.</value>
        [JsonProperty("transaction_type")]
        public string TransactionType { get; set; }

        /// <value>VAT number</value>
        [JsonProperty("vat_number")]
        public string VatNumber { get; set; }

        /// <value>Expiration year</value>
        [JsonProperty("year")]
        public string Year { get; set; }

    }
}
