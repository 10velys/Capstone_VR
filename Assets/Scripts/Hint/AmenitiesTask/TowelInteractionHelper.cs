using UnityEngine;

using UnityEngine.XR.Interaction.Toolkit;

// Unity 6 Namespace

using UnityEngine.XR.Interaction.Toolkit.Interactables;



public class TowelInteractionHelper : MonoBehaviour

{

    private XRGrabInteractable grabInteractable;

    private TowelHintController hintController;



    void Start()

    {

        grabInteractable = GetComponent<XRGrabInteractable>();

       

        // Cari controller khusus Towel

        hintController = FindFirstObjectByType<TowelHintController>();



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

            // Kirim referensi diri sendiri (game object handuk)

            hintController.OnTowelGrabbed(this.gameObject);

        }

    }



    private void OnDrop(SelectExitEventArgs args)

    {

        if (hintController != null)

        {

            hintController.OnTowelDropped();

        }

    }

}