using UnityEngine;

public class PopupManager : MonoBehaviour
{
    public GameObject popupPanel;
    private int buttonClickCount = 0;
    private const int RequiredClicks = 3;
    private bool hasTriggered = false;

    public void OnButtonClick()
    {
        if (hasTriggered) return;

        buttonClickCount++;
        Debug.Log("Buttons clicked: " + buttonClickCount);

        if (buttonClickCount >= RequiredClicks)
        {
            hasTriggered = true;
            Invoke(nameof(ShowPopup), 3f);
        }
    }

    private void ShowPopup()
    {
        if (popupPanel != null)
        {
            popupPanel.SetActive(true);
        }
    }
}