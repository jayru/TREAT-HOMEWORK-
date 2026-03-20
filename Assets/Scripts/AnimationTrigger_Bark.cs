using UnityEngine;
using UnityEngine.UI;

public class AnimationTrigger_Bark : MonoBehaviour
{
    public Animator modelAnimator; // Drag your 3D model here in the Inspector
    public string triggerName; // The name of the trigger parameter in the Animator

    // This public function will be called by the UI button
    public void PlayModelAnimation()
    {
        if (modelAnimator != null)
        {
            modelAnimator.SetTrigger(triggerName); // Activate the trigger
        }
    }
}
