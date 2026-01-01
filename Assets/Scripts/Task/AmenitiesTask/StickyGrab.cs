using UnityEngine;

using UnityEngine.XR.Interaction.Toolkit;

using UnityEngine.XR.Interaction.Toolkit.Interactables;

using UnityEngine.XR.Interaction.Toolkit.Interactors;

using System.Collections;



public class StickyGrab : MonoBehaviour

{

    private XRGrabInteractable grabInteractable;

    private Rigidbody rb;



    void Start()

    {

        grabInteractable = GetComponent<XRGrabInteractable>();

        rb = GetComponent<Rigidbody>();



        if (grabInteractable != null)

        {

            grabInteractable.selectExited.AddListener(OnObjectDropped);

        }

    }



    private void OnObjectDropped(SelectExitEventArgs args)

    {

        IXRSelectInteractor handInteractor = args.interactorObject;

        StartCoroutine(ForceReGrab(handInteractor));

    }



    IEnumerator ForceReGrab(IXRSelectInteractor hand)

    {

        yield return null;



        if (this != null && gameObject.activeInHierarchy)

        {

            Debug.Log("Salah tempat! Handuk kembali ke tangan.");



            if (rb != null)

            {

                // --- PERBAIKAN DI SINI (Unity 6) ---

                // Ganti 'velocity' menjadi 'linearVelocity'

                rb.linearVelocity = Vector3.zero;

                rb.angularVelocity = Vector3.zero;

            }



            transform.position = hand.transform.position;

            transform.rotation = hand.transform.rotation;



            var manager = grabInteractable.interactionManager;

            if (manager != null)

            {

                manager.SelectEnter(hand, (IXRSelectInteractable)grabInteractable);

            }

        }

    }

}