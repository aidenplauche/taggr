namespace TAGGR.Components.Forms;

using TAGGR.Components.Models;


public partial class CreateCardForm
{
    private bool showPopup = false;
    private string newCardName = "";
    private string newCardDescription = "";
    public List<Card> cards = new();

    public void OpenPopup()
    {
        showPopup = true;
        StateHasChanged();
    }

    private void ClosePopup()
    {
        showPopup = false;
        // Reset form fields
        newCardName = "";
        newCardDescription = "";
    }

    private void SaveCard()
    {
        if (!string.IsNullOrWhiteSpace(newCardName))
        {
            cards.Add(new Card(newCardName, newCardDescription));
            ClosePopup();
        }
    }
}
