using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ValletComTR_Ornek
{
    public struct ProductData
    {
        /// <summary>
        /// Sipariş yada Fatura Adı Max 200 karakter
        /// </summary>
        public string productName { get; set; }
        public decimal productPrice { get; set; }

        /// <summary>
        /// FIZIKSEL_URUN  veya   DIJITAL_URUN
        /// </summary>
        public string productType { get; set; }
    }
}