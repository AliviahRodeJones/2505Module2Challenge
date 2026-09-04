using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module2Challenge.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public double milesDriven { get; set; }
   
    public double gallonsUsed { get; set; }
    public double TotalCost { get; set; }
    public bool ShowResult { get; set; }

    public void OnGet()
    {
        ShowResult = false;
    }
}
