using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module2Challenge.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    // Tells C# to populate with data from HTTP
    public double milesDriven { get; set; }
    // This variable holds the amount of miles driven the user enters.
   
    [BindProperty]
    // Tells C# to populate with data from HTTP
    public double gallonsUsed { get; set; }
    // This variable holds the amount of gas used that the user enters.
    public double milesPerGallon { get; set; }
    // A variable for the to-be-calculated miles per gallon.
    public bool showResult { get; set; }
    // This variable tells the page to show the result.

    public void OnGet()
    {
        showResult = false;
        // When the page is accessed by any user, ShowResult is automatically set to false,
        //  so it doesn't show the blank result info.
    }
    public void OnPost()
    // This function runs after the HTML form is posted. 
    {
        double MPG = milesDriven / gallonsUsed;
        milesPerGallon = MPG;
        // This block of code calculates the miles per gallon based on the user entered 
         
        showResult = true;
        // The page now shows the result of the calculation.
    }
}
