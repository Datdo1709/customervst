namespace VSTCustomer.Models
{
    public class ORDERED
    {
        public required string ID { get; set; }
        public string EMP_ID { get; set; } = string.Empty;
        public DateTime ORDED_DATE { get; set; }
        public string CUSTOMER_ID { get; set; } = string.Empty;
        public string? ORDER_CR_HR { get; set; }
        public string? STS_ST_CLS { get; set; }
        public string? STS_ST_SER { get; set; } 
        public string? SURFACE_CD { get; set; }
        public decimal? ORD_THK { get; set; }
        public decimal? ORD_WTH { get; set; }
        public string? ORD_EDGE { get; set; }
        public decimal? ORD_WGT { get; set; }
        public decimal? BASE_PRICE { get; set; }
        public decimal? EFFECT_PRICE { get; set; }
        public decimal? BIDD_PRICE { get; set; }
        public string? CONTRACT_NO { get; set; }
        public string? ORD_USAGE { get; set; } 
        public string? ORD_STAT { get; set; } 
        public string? END_USER { get; set; }
        public decimal? QUANTITY { get; set; }
        public string? DELIVERY_TIME { get; set; } 
        public string? REMARK { get; set; } 
        public DateTime? CREATE_AT { get; set; }
    }
}
