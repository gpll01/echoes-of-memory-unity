using UnityEngine;

public class MemoryReveal : MonoBehaviour
{
    Renderer[] renderers;
    Light[] lights;
    AudioSource audioSource;

    void Start()
    {
        renderers = GetComponentsInChildren<Renderer>();
        lights = GetComponentsInChildren<Light>();
        audioSource = GetComponent<AudioSource>();

        foreach (Renderer r in renderers)
        {
            r.enabled = false;
        }

        foreach (Light l in lights)
        {
            l.enabled = false;
        }
    }

    public void Reveal()
    {
        foreach (Renderer r in renderers)
        {
            r.enabled = true;
        }

        foreach (Light l in lights)
        {
            l.enabled = true;
        }

        Invoke("StopSound", 4f);
    }

    void StopSound()
    {
        if (audioSource != null)
        {
            audioSource.Stop();
        }
    }
}