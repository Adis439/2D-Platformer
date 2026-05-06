using UnityEngine;

namespace Cainos.PixelArtPlatformer_VillageProps
public class Chest : MonoBehaviour
{
    [Header("Reference")]
    [SerializeField] private Animator animator;

    [Header("Runtime")]
    [SerializeField] private bool isOpened = false;

    // Property to control animation
    public bool IsOpened
    {
        get => isOpened;
        set
        {
            isOpened = value;

            if (animator != null)
            {
                animator.SetBool("IsOpened", isOpened);
            }
            else
            {
                Debug.LogWarning("Animator is not assigned on " + gameObject.name);
            }
        }
    }

    private void Start()
    {
        // Sync animation state on start
        IsOpened = isOpened;
    }

    // Called to open chest
    public void Open()
    {
        if (isOpened) return;

        IsOpened = true;
    }

    // Called to close chest (optional)
    public void Close()
    {
        if (!isOpened) return;

        IsOpened = false;
    }

    // Trigger when player enters
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Open();
        }
    }
}