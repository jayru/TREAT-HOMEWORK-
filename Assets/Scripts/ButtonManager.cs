using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Animator targetAnimator; // Drag the object with animator here
    public string triggerName = "Button_Exit"; // Match parameter name

    private int buttonsClicked = 0;
    private bool animationPlayed = false;

    // Call this method from button OnClick()
    public void ButtonPressed()
    {
        if (animationPlayed) return;

        buttonsClicked++;
        Debug.Log("Buttons clicked: " + buttonsClicked);

        if (buttonsClicked >= 3)
        {
            PlayAnimation();
        }
    }

    private void PlayAnimation()
    {
        if (targetAnimator != null)
        {
            targetAnimator.SetTrigger(triggerName);
            animationPlayed = true;
            Debug.Log("Animation Triggered!");
        }
    }
}
