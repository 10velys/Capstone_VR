using UnityEngine;



public class BedHintController : MonoBehaviour

{

    [Header("Visual")]

    public GameObject hintDiamond;

    public Vector3 offset = new Vector3(0, 0.5f, 0); // Tinggi hint dari objek



    [Header("Referensi Logic")]

    public BedTaskManager bedManager; // Untuk akses daftar bantal & zona



    // State Internal

    private int currentTargetIndex = 0;

    private bool isHoldingCurrentPillow = false;

    private bool allTasksCompleted = false;



    void Update()

    {

        if (allTasksCompleted || hintDiamond == null) return;



        // 1. Tentukan Posisi Target

        Vector3 targetPos = CalculateTargetPosition();

        hintDiamond.transform.position = targetPos;



        // 2. Rotasi Horizontal (Stabil)

        hintDiamond.transform.Rotate(0, 50f * Time.deltaTime, 0, Space.World);

    }



    Vector3 CalculateTargetPosition()

    {

        // PERBAIKAN DI SINI:

        // Cek apakah index sudah melebihi jumlah total bantal (4 buah: index 0-3)

        // Jika index >= 4, berarti tidak ada target valid.

        if (currentTargetIndex >= 4) return hintDiamond.transform.position;



        // --- SKENARIO A: Sedang Pegang Bantal Target ---

        // Hint menunjuk ke ZONA (Tempat menaruh bantal)

        if (isHoldingCurrentPillow)

        {

            // Ambil collider zona target saat ini

            if (currentTargetIndex < bedManager.pillowTargetZones.Length)

            {

                return bedManager.pillowTargetZones[currentTargetIndex].transform.position + offset;

            }

        }

       

        // --- SKENARIO B: Belum Pegang Bantal ---

        // Hint menunjuk ke BANTAL yang harus diambil

        else

        {

            // Kita akses array bantal lewat manager

            // (Kita asumsikan urutan bantal di manager: Pillow 1, 2, 3, 4)

            var targetPillow = GetPillowByIndex(currentTargetIndex);

           

            if (targetPillow != null)

            {

                return targetPillow.transform.position + offset;

            }

        }



        return hintDiamond.transform.position;

    }



    // Helper untuk mengambil bantal berdasarkan index dari Manager

    Transform GetPillowByIndex(int index)

    {

        switch (index)

        {

            case 0: return bedManager.pillow1 != null ? bedManager.pillow1.transform : null;

            case 1: return bedManager.pillow2 != null ? bedManager.pillow2.transform : null;

            case 2: return bedManager.pillow3 != null ? bedManager.pillow3.transform : null;

            case 3: return bedManager.pillow4 != null ? bedManager.pillow4.transform : null;

            default: return null;

        }

    }



    // Dipanggil oleh Helper di Bantal

    public void OnPillowGrabbed(GameObject grabbedObj)

    {

        Transform targetPillow = GetPillowByIndex(currentTargetIndex);

       

        // Cek: Apakah yang dipegang adalah bantal target saat ini?

        if (targetPillow != null && grabbedObj.transform == targetPillow)

        {

            isHoldingCurrentPillow = true;

        }

    }



    public void OnPillowDropped()

    {

        isHoldingCurrentPillow = false;

    }



    // Dipanggil oleh BedTaskManager saat Snapping sukses

    public void OnPillowPlacedSuccess(int placedIndex)

    {

        // Pastikan suksesnya berurutan atau sesuai target saat ini

        if (placedIndex == currentTargetIndex)

        {

            Debug.Log($"Hint: Bantal {placedIndex + 1} Selesai. Lanjut next.");

            isHoldingCurrentPillow = false;

            currentTargetIndex++;



            // Cek apakah sudah habis (4 bantal)

            if (currentTargetIndex >= 4) // Anggap ada 4 bantal

            {

                allTasksCompleted = true;

                hintDiamond.SetActive(false);

            }

        }

    }

}