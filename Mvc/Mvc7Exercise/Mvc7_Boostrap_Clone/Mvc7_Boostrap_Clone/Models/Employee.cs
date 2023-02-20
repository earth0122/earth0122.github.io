using System.ComponentModel.DataAnnotations;

namespace Mvc7_Boostrap_Clone.Models;

public class Employee
{
    [Display(Name = "員工編號")]
    public int Id { get; set; }
    [Display(Name = "姓名")]
    public string Name { get; set; }
    [Display(Name = "行動電話")]
    public string Mobile { get; set; }
    [Display(Name = "電子郵件")]
    public string Email { get; set; }
    [Display(Name = "部門")]
    public string Department { get; set; }
    [Display(Name = "職稱")]
    public string Title { get; set; }
}
