using UnityEngine;

using UnityEngine.XR.Interaction.Toolkit;

// Note: Unity 6 mungkin butuh namespace ini:

// using UnityEngine.XR.Interaction.Toolkit.Interactables;



public class TrashInteractionHelper : MonoBehaviour

{

    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable;

    private TrashHintController hintController;



    void Start()

    {

        grabInteractable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();

       

        // Cari controller secara otomatis di scene

        hintController = FindFirstObjectByType<TrashHintController>();



        // Safety check

        if (grabInteractable != null)

        {

            // Subscribe event Unity XR (Saat Grab & Drop)

            grabInteractable.selectEntered.AddListener(OnGrab);

            grabInteractable.selectExited.AddListener(OnDrop);

        }

    }



    private void OnDestroy()

    {

        // Bersih-bersih event saat object hancur/mati

        if (grabInteractable != null)

        {

            grabInteractable.selectEntered.RemoveListener(OnGrab);

            grabInteractable.selectExited.RemoveListener(OnDrop);

        }

    }



    // Event saat Player memegang benda ini

    private void OnGrab(SelectEnterEventArgs args)

    {

        if (hintController != null)

        {

            hintController.OnTrashGrabbed(this.gameObject);

        }

    }



    // Event saat Player melepas benda ini

    private void OnDrop(SelectExitEventArgs args)

    {

        if (hintController != null)

        {

            hintController.OnTrashDropped();

        }

    }

}