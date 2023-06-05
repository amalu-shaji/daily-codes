﻿namespace ProductMicroservice.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public decimal CategoryId { get; set;}
    }
}
