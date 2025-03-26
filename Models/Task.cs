namespace TaskGestionAPI.Models;
using System;
using System.ComponentModel.DataAnnotations;

public class Task
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreationDate { get; set; } = DateTime.Now;
    public DateTime? ExpirationDate { get; set; }
    public string Priority { get; set; }
    public string Status { get; set; }
}