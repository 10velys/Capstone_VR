using UnityEngine;

using UnityEngine.XR.Interaction.Toolkit;

// Unity 6 Namespace

using UnityEngine.XR.Interaction.Toolkit.Interactables;



public class BedInteractionHelper : MonoBehaviour

{

    private XRGrabInteractable grabInteractable;

    private BedHintController hintController;



    void Start()

    {

        grabInteractable = GetComponent<XRGrabInteractable>();

       

        // Cari controller khusus Bed

        hintController = FindFirstObjectByType<BedHintController>();



        if (grabInteractable != null)

        {

            grabInteractable.selectEntered.AddListener(OnGrab);

            grabInteractable.selectExited.AddListener(OnDrop);

        }

    }



    private void OnDestroy()

    {

        if (grabInteractable != null)

        {

            grabInteractable.selectEntered.RemoveListener(OnGrab);

            grabInteractable.selectExited.RemoveListener(OnDrop);

        }

    }



    private void OnGrab(SelectEnterEventArgs args)

    {

        if (hintController != null)

        {

            // Lapor ke hint controller: "Saya (Bantal ini) sedang dipegang"

            hintController.OnPillowGrabbed(this.gameObject);

        }

    }



    private void OnDrop(SelectExitEventArgs args)

    {

        if (hintController != null)

        {

            hintController.OnPillowDropped();

        }

    }

}