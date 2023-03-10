using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ValletComTR_Ornek
{
    public class ValletConfig
    {
        /// <summary>
        /// Api Kullanıcı Adınız
        /// </summary>
        public string userName { get; set; }
        /// <summary>
        /// Api Şifreniz (KEY)
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// Api Mağaza Kodunuz
        /// </summary>
        public string shopCode { get; set; }

        /// <summary>
        /// Api Hash Anahtarınız
        /// </summary>
        public string hash { get; set; }

    }
}