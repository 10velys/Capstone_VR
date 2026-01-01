using UnityEngine;

using UnityEngine.XR.Interaction.Toolkit;

// Unity 6 Namespace

using UnityEngine.XR.Interaction.Toolkit.Interactables;

using System.Collections; // Wajib untuk IEnumerator



public class BinLogic : MonoBehaviour

{

    public TrashHintController hintController;



    private void OnTriggerEnter(Collider other)

    {

        if (other.CompareTag("Sampah"))

        {

            // 1. Validasi ke Controller: "Ini sampah yang benar bukan?"

            // Kita kirim 'other.gameObject' untuk dicek

            if (hintController != null)

            {

                hintController.OnTaskSuccess(other.gameObject);

            }



            // 2. Lepaskan paksa dari tangan (Force Drop)

            var grabInteractable = other.GetComponent<XRGrabInteractable>();

            if (grabInteractable != null)

            {

                if (grabInteractable.isSelected)

                {

                    grabInteractable.interactionManager.CancelInteractableSelection(grabInteractable as IXRSelectInteractable);

                }

                Destroy(grabInteractable); // Hapus kemampuan grab

            }



            // 3. Hapus Helper & Komponen lain

            var helper = other.GetComponent<TrashInteractionHelper>();

            if (helper) Destroy(helper);



            // 4. JANGAN BEKUKAN SEKARANG. TUNGGU JATUH DULU.

            Rigidbody rb = other.GetComponent<Rigidbody>();

            if (rb != null)

            {

                StartCoroutine(FreezeTrashDelayed(rb));

            }

        }

    }



    // Coroutine untuk menunggu sampah jatuh ke dasar

    IEnumerator FreezeTrashDelayed(Rigidbody rb)

    {

        // Tunggu 1 detik (sesuaikan dengan kedalaman tong sampah)

        yield return new WaitForSeconds(1.0f);



        if (rb != null)

        {

            rb.isKinematic = true; // Baru matikan fisika di sini

            rb.linearVelocity = Vector3.zero;

            rb.angularVelocity = Vector3.zero;

           

            Debug.Log("Sampah berhasil mendarat dan dibekukan.");

        }

    }

}