using UnityEngine;
public class CanvasFX : MonoBehaviour
{
    public ParticleSystem exitParticles;
    public void PlayExitEffect()
    {
        if (exitParticles != null) exitParticles.Play();
    }
}
