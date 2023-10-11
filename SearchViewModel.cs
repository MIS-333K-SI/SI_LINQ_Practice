    public enum PriceSearchType { GreaterThan, LessThan }
	
	public class SearchViewModel
	{
        [Display(Name = "Search by Title:")]
        public String SearchName { get; set; }

        [Display(Name = "Search by Description:")]
        public String SearchDescription { get; set; }

        [Display(Name = "Search by Format:")]
        public Format? SelectedFormat { get; set; }

        [Display(Name = "Search by Genre:")]
        public Int32 SelectedGenreID { get; set; }

        [Display(Name = "Search by Price:")]
        public Decimal? SearchPrice { get; set; }

        [Display(Name = "Type of Search:")]
        public PriceSearchType SelectedType { get; set; } 

        [Display(Name = "Search by Published Date:")]
        [DataType(DataType.Date)]
        public DateTime? SelectedDate { get; set; }
    }

