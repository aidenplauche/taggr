using Microsoft.AspNetCore.Components.Web;

// Handles dynamic elements on Home Page
namespace TAGGR.Components.Pages
{
    public partial class Home
    {
        private string cardPageWidth = $"{200}px";
        private bool isResizing = false;

        // testing using lists from code to unpack on frontend
        private List<string> cardItems = new List<string> 
        {
            "Card 1",
            "Card 2",
            "Card 3"
        };

        // Populate detail page based on selected card
        private void OnCardSelected(string card)
        {
            // Logic to handle card selection
        }

        private void selectResizeBar(MouseEventArgs e)
        {
            isResizing = true;
        }
        private void releaseResizeBar(MouseEventArgs e) 
        {
            isResizing = false;
        }

        private void resizePage(MouseEventArgs e)
        {
            if (isResizing)
            {
                cardPageWidth = $"{e.ClientX -325}px";     
            }
        }
    }
}