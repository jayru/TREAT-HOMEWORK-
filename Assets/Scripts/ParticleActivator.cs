using UnityEngine;

public class ParticleActivator : MonoBehaviour
{
    public ParticleSystem particles;

    // This method will be called by the Animation Event
    public void TriggerParticles()
    {
        if (particles != null)
        {
            particles.Play();
        }
    }
}
