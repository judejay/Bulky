using BulkyWeb_Razor_Temp.Data;
using BulkyWeb_Razor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWeb_Razor_Temp.Pages.Categories
{
    public class IndexModel(ApplicationDbContext db) : PageModel
    {
        public List<Category>? CategoresList { get; set; }

        public void OnGet()
        {
            CategoresList = [.. db.Categories];
        }
    }
}
