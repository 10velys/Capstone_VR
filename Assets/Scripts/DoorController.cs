using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Animator doorAnimator;

    private bool isOpen = false;

    public void ToggleDoor()
    {
        isOpen = !isOpen;

        doorAnimator.SetBool("isOpen", isOpen);
    }
}