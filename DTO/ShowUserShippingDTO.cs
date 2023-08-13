﻿namespace EcommerseApplication.DTO
{
    public class ShowUserShippingDTO
    {
        public int ID { get; set; }
        public string? shipName { get; set; }
        public string shippingstate { get; set; }//(Pick-up, on-process, on-delivery, Delivered)


        public string? arabicshippingstate
        {
            get; set;
        }
        public string? shipperName { get; set; }
        public string? shipperPhone { get; set; }
        public string? ALLaddress { get; set; }
        public string? ALLaddress_Ar { get; set; }
    }
}
