using UnityEngine;

public class MemoryTrigger : MonoBehaviour
{
    public MemoryReveal memoryReveal;

    bool discovered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (discovered) return;

        if (other.CompareTag("Player"))
        {
            discovered = true;

            memoryReveal.Reveal();

            MemoryCounter.Instance.MemoryFound();
        }
    }
}
