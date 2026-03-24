namespace VSTCustomer.Models
{
    public class ORDERED
    {
        public required string ID { get; set; }
        public string EMP_ID { get; set; } = string.Empty;
        public DateTime ORDED_DATE { get; set; }
        public string CUSTOMER_ID { get; set; } = string.Empty;
        public string ORDER_CR_HR { get; set; } = string.Empty;
        public string STS_ST_CLS { get; set; } = string.Empty;
        public string STS_ST_SER { get; set; } = string.Empty;
        public string SURFACE_CD { get; set; } = string.Empty;
        public decimal ORD_THK { get; set; }
        public decimal ORD_WTH { get; set; }
        public string ORD_EDGE { get; set; } = string.Empty;
        public decimal ORD_WGT { get; set; }
        public decimal BASE_PRICE { get; set; }
        public decimal EFFECT_PRICE { get; set; }
        public decimal BIDD_PRICE { get; set; }
        public string CONTRACT_NO { get; set; } = string.Empty;
        public string ORD_USAGE { get; set; } = string.Empty;
        public string ORD_STAT { get; set; } = string.Empty;
        public string END_USER { get; set; } = string.Empty;
        public int QUANTITY { get; set; }
        public string DELIVERY_TIME { get; set; } = string.Empty;
        public string REMARK { get; set; } = string.Empty;
        public DateTime CREATE_AT { get; set; }
    }
}
