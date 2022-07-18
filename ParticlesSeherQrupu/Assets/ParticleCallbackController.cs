using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCallbackController : MonoBehaviour
{
    private void OnParticleSystemStopped()
    {
        Debug.Log("particle stopped");
    }

    private void OnParticleCollision(GameObject other)
    {
        Debug.Log("Particle collided with :" + other.name);
    }

    private void OnParticleTrigger()
    {
        Debug.Log("Trigger entered");
    }
}
