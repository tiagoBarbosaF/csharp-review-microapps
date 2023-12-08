namespace DatabaseReview.Models;

public class Product
{
    public long Id { get; init; }
    public string Name { get; init; }
    public string Description { get; init; }
    public decimal Value { get; init; }

    public override string ToString()
    {
        return $"Product - Id: {Id}, Name: {Name}, Description: {Description}, Value: {Value}";
    }
}