using UnityEngine;



public class TowelHintController : MonoBehaviour

{

    [Header("Visual")]

    public GameObject hintDiamond;

    public Vector3 offset = new Vector3(0, 0.3f, 0);



    [Header("Referensi Objek")]

    public Transform dirtyTowelTarget;  // Handuk Kotor (Awal)

    public Transform basketTarget;      // Target Handuk Kotor (Basket 2)

    public Transform cleanTowelTarget;  // Handuk Bersih (di Basket 1)

    public Transform rackTarget;        // Target Handuk Bersih (Heated Towel)



    // State

    // 0 = Fase Handuk Kotor

    // 1 = Fase Handuk Bersih

    // 2 = Selesai

    private int currentStep = 0;

    private bool isHoldingTowel = false;



    void Update()

    {

        if (currentStep >= 2 || hintDiamond == null) return;



        // 1. Tentukan Posisi

        Vector3 targetPos = CalculatePosition();

        hintDiamond.transform.position = targetPos;



        // 2. Rotasi Horizontal

        hintDiamond.transform.Rotate(0, 50f * Time.deltaTime, 0, Space.World);

    }



    Vector3 CalculatePosition()

    {

        // --- FASE 1: HANDUK KOTOR ---

        if (currentStep == 0)

        {

            if (isHoldingTowel)

            {

                // Kalau sedang pegang handuk kotor -> Tunjuk Basket 2

                return basketTarget.position + offset;

            }

            else

            {

                // Kalau belum pegang -> Tunjuk Handuk Kotor itu sendiri

                if (dirtyTowelTarget != null)

                    return dirtyTowelTarget.position + offset;

            }

        }

        // --- FASE 2: HANDUK BERSIH ---

        else if (currentStep == 1)

        {

            if (isHoldingTowel)

            {

                // Kalau sedang pegang handuk bersih -> Tunjuk Rak

                return rackTarget.position + offset;

            }

            else

            {

                // Kalau belum pegang -> Tunjuk Handuk Bersih

                if (cleanTowelTarget != null)

                    return cleanTowelTarget.position + offset;

            }

        }



        return hintDiamond.transform.position; // Fallback

    }



    // Dipanggil oleh Helper saat handuk di-grab

    public void OnTowelGrabbed(GameObject grabbedObj)

    {

        // Cek apakah handuk yang dipegang sesuai dengan phase saat ini

        if (currentStep == 0 && grabbedObj.transform == dirtyTowelTarget)

        {

            isHoldingTowel = true;

        }

        else if (currentStep == 1 && grabbedObj.transform == cleanTowelTarget)

        {

            isHoldingTowel = true;

        }

    }



    public void OnTowelDropped()

    {

        isHoldingTowel = false;

    }



    // Dipanggil oleh TowelTaskManager saat Handuk Kotor masuk Basket

    public void OnDirtyTaskFinished()

    {

        Debug.Log("Hint: Fase Dirty Selesai. Lanjut ke Clean.");

        isHoldingTowel = false;

        currentStep = 1; // Pindah ke fase Handuk Bersih

    }



    // Dipanggil oleh TowelTaskManager saat Handuk Bersih masuk Rak

    public void OnCleanTaskFinished()

    {

        Debug.Log("Hint: Semua Selesai!");

        isHoldingTowel = false;

        currentStep = 2; // Selesai

        hintDiamond.SetActive(false);

    }

}