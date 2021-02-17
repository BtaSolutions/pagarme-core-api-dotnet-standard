/*
 * PagarmeCoreApi.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PagarmeCoreApi.Standard;
using PagarmeCoreApi.Standard.Utilities;


namespace PagarmeCoreApi.Standard.Models
{
    public class CreateCheckoutPaymentRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<string> acceptedPaymentMethods;
        private object acceptedMultiPaymentMethods;
        private string successUrl;
        private string defaultPaymentMethod;
        private string gatewayAffiliationId;
        private Models.CreateCheckoutCreditCardPaymentRequest creditCard;
        private Models.CreateCheckoutDebitCardPaymentRequest debitCard;
        private Models.CreateCheckoutBoletoPaymentRequest boleto;
        private bool? customerEditable;
        private int? expiresIn;
        private bool skipCheckoutSuccessPage;
        private bool billingAddressEditable;
        private Models.CreateAddressRequest billingAddress;
        private Models.CreateCheckoutBankTransferRequest bankTransfer;

        /// <summary>
        /// Accepted Payment Methods
        /// </summary>
        [JsonProperty("accepted_payment_methods")]
        public List<string> AcceptedPaymentMethods 
        { 
            get 
            {
                return this.acceptedPaymentMethods; 
            } 
            set 
            {
                this.acceptedPaymentMethods = value;
                onPropertyChanged("AcceptedPaymentMethods");
            }
        }

        /// <summary>
        /// Accepted Multi Payment Methods
        /// </summary>
        [JsonProperty("accepted_multi_payment_methods")]
        public object AcceptedMultiPaymentMethods 
        { 
            get 
            {
                return this.acceptedMultiPaymentMethods; 
            } 
            set 
            {
                this.acceptedMultiPaymentMethods = value;
                onPropertyChanged("AcceptedMultiPaymentMethods");
            }
        }

        /// <summary>
        /// Success url
        /// </summary>
        [JsonProperty("success_url")]
        public string SuccessUrl 
        { 
            get 
            {
                return this.successUrl; 
            } 
            set 
            {
                this.successUrl = value;
                onPropertyChanged("SuccessUrl");
            }
        }

        /// <summary>
        /// Default payment method
        /// </summary>
        [JsonProperty("default_payment_method")]
        public string DefaultPaymentMethod 
        { 
            get 
            {
                return this.defaultPaymentMethod; 
            } 
            set 
            {
                this.defaultPaymentMethod = value;
                onPropertyChanged("DefaultPaymentMethod");
            }
        }

        /// <summary>
        /// Gateway Affiliation Id
        /// </summary>
        [JsonProperty("gateway_affiliation_id")]
        public string GatewayAffiliationId 
        { 
            get 
            {
                return this.gatewayAffiliationId; 
            } 
            set 
            {
                this.gatewayAffiliationId = value;
                onPropertyChanged("GatewayAffiliationId");
            }
        }

        /// <summary>
        /// Credit Card payment request
        /// </summary>
        [JsonProperty("credit_card")]
        public Models.CreateCheckoutCreditCardPaymentRequest CreditCard 
        { 
            get 
            {
                return this.creditCard; 
            } 
            set 
            {
                this.creditCard = value;
                onPropertyChanged("CreditCard");
            }
        }

        /// <summary>
        /// Debit Card payment request
        /// </summary>
        [JsonProperty("debit_card")]
        public Models.CreateCheckoutDebitCardPaymentRequest DebitCard 
        { 
            get 
            {
                return this.debitCard; 
            } 
            set 
            {
                this.debitCard = value;
                onPropertyChanged("DebitCard");
            }
        }

        /// <summary>
        /// Boleto payment request
        /// </summary>
        [JsonProperty("boleto")]
        public Models.CreateCheckoutBoletoPaymentRequest Boleto 
        { 
            get 
            {
                return this.boleto; 
            } 
            set 
            {
                this.boleto = value;
                onPropertyChanged("Boleto");
            }
        }

        /// <summary>
        /// Customer is editable?
        /// </summary>
        [JsonProperty("customer_editable")]
        public bool? CustomerEditable 
        { 
            get 
            {
                return this.customerEditable; 
            } 
            set 
            {
                this.customerEditable = value;
                onPropertyChanged("CustomerEditable");
            }
        }

        /// <summary>
        /// Time in minutes for expiration
        /// </summary>
        [JsonProperty("expires_in")]
        public int? ExpiresIn 
        { 
            get 
            {
                return this.expiresIn; 
            } 
            set 
            {
                this.expiresIn = value;
                onPropertyChanged("ExpiresIn");
            }
        }

        /// <summary>
        /// Skip postpay success screen?
        /// </summary>
        [JsonProperty("skip_checkout_success_page")]
        public bool SkipCheckoutSuccessPage 
        { 
            get 
            {
                return this.skipCheckoutSuccessPage; 
            } 
            set 
            {
                this.skipCheckoutSuccessPage = value;
                onPropertyChanged("SkipCheckoutSuccessPage");
            }
        }

        /// <summary>
        /// Billing Address is editable?
        /// </summary>
        [JsonProperty("billing_address_editable")]
        public bool BillingAddressEditable 
        { 
            get 
            {
                return this.billingAddressEditable; 
            } 
            set 
            {
                this.billingAddressEditable = value;
                onPropertyChanged("BillingAddressEditable");
            }
        }

        /// <summary>
        /// Billing Address
        /// </summary>
        [JsonProperty("billing_address")]
        public Models.CreateAddressRequest BillingAddress 
        { 
            get 
            {
                return this.billingAddress; 
            } 
            set 
            {
                this.billingAddress = value;
                onPropertyChanged("BillingAddress");
            }
        }

        /// <summary>
        /// Bank Transfer payment request
        /// </summary>
        [JsonProperty("bank_transfer")]
        public Models.CreateCheckoutBankTransferRequest BankTransfer 
        { 
            get 
            {
                return this.bankTransfer; 
            } 
            set 
            {
                this.bankTransfer = value;
                onPropertyChanged("BankTransfer");
            }
        }
    }
} 