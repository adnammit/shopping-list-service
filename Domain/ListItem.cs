namespace ChecklistAPI.Domain;

public class ListItem : BaseEntity
{
	public required string Name { get; set; }
	public string? Notes { get; set; }
	public int? Quantity { get; set; }
	public string? Category { get; set; }
	// public Category Category { get; set; }
	public bool Completed { get; set; }
}
