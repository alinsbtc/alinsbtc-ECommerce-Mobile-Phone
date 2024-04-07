namespace E_Commerce_Mobile_Phone.ViewModels
{
    public class ProductVM
    {
        public int Id { get; set; }
        public int CatId { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Avatar { get; set; }
        public string Img { get; set; }
        public string SortDesc { get; set; }
        public string Detail { get; set; }
        public string Producer { get; set; }
        public int Number { get; set; }
        public int NumberBuy { get; set; }
        public int? Sale { get; set; }
        public int Price { get; set; }
        public int PriceSale { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool Trash { get; set; }
        public bool Access { get; set; }
        public bool Status { get; set; }
        public string MetaKey { get; set; }
        public string MetaDesc { get; set; }
    }
}
