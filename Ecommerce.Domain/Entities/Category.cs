namespace Ecommerce.Domain.Entities
{
    public class Category:BaseEntity<int>
    {
        public Category(string name,string discription)
        {
            this.Name = name;
            this.Description = discription;
        }
        public string Name { set; get; }
        public string Description { set; get; }

    }
}
