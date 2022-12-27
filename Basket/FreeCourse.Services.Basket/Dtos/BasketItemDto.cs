namespace FreeCourse.Services.Basket.Dtos
{
    public class BasketItemDto
    {
        public int Quantity { get; set; }
        public string CourseId { get; set; }
        public string CourrseName { get; set; }
        public decimal Price { get; set; }
    }
}
