using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ValletComTR_Ornek
{
    public struct PostData
    {
        public string userName { get; set; }
        public string password { get; set; }
        public string shopCode { get; set; }
        /// <summary>
        /// Maks 200 karakter
        /// </summary>
        public string productName { get; set; }
        public List<ProductData> productData { get; set; }


        /// <summary>
        /// FIZIKSEL_URUN  veya   DIJITAL_URUN
        /// </summary>
        public string productType { get; set; }

        /// <summary>
        /// Siparişe ait sepetteki ürünlerin toplam tutarı.
        /// </summary>
        public decimal productsTotalPrice { get; set; }

        /// <summary>
        /// Api üzerinden geçecek nihai tutar. Taksit oranları bu tutar üzerine eklenerek hesaplanır.
        /// </summary>
        public decimal orderPrice { get; set; }

        /// <summary>
        /// TRY,EUR,USD
        /// </summary>
        public string currency { get; set; }

        /// <summary>
        /// Maks 50 karakter, İlgili siparişinizin sizin sisteminiz tarafındaki sipariş ID yada Sipariş Kodu. Ödenmemiş bir sipariş yada benzersiz olmalıdır.
        /// </summary>
        public string orderId { get; set; }

        /// <summary>
        /// tr,en,de,ru
        /// </summary>
        public string locale { get; set; }

        /// <summary>
        /// Maks 200 karakter, İstekte gönderilirse response olarak size geri döndürülür. Request/response eşlemesi yapmak için kullanılır.
        /// </summary>
        public string conversationId { get; set; }

        /// <summary>
        /// Sipariş Sahibi Adı
        /// </summary>
        public string buyerName { get; set; }

        /// <summary>
        /// Şipariş Sahibi Soyadı
        /// </summary>
        public string buyerSurName { get; set; }

        /// <summary>
        /// Sipariş Sahibi Telefon Numarası Uyarı: Telefon yanlış olan siparişler iptal edilir. Güvenlik doğrulaması için müşteriye ulaşılması gerekebilir.
        /// </summary>
        public string buyerGsmNo { get; set; }
        public string buyerIp { get; set; }

        /// <summary>
        /// Maks 80
        /// </summary>
        public string buyerMail { get; set; }

        /// <summary>
        /// Maks 200
        /// </summary>
        public string buyerAdress { get; set; }

        /// <summary>
        /// Müşteri ÜLKE, Maks 70
        /// </summary>
        public string buyerCountry { get; set; }

        /// <summary>
        /// Müşteri Şehir, Maks 70
        /// </summary>
        public string buyerCity { get; set; }

        /// <summary>
        /// Müşteri İlçe Maks 70
        /// </summary>
        public string buyerDistrict { get; set; }

        /// <summary>
        /// Müşterinin başarılı işlemde yönlendirileceği sayfa
        /// </summary>
        public string callbackOkUrl { get; set; }

        /// <summary>
        /// Müşterinin başarısız işlemde yönlendirileceği sayfa
        /// </summary>
        public string callbackFailUrl { get; set; }

        public static string module = "NATIVE_NET";

        /// <summary>
        /// bu değeri boş gönderin
        /// </summary>
        public string hash { get; set; }

    }
}