using UnityEngine;



public class TowelSensor : MonoBehaviour

{

    public enum SensorType { DirtyBasket, CleanRack }

    public SensorType sensorType;



    public TowelTaskManager manager; // Referensi ke Manager



    private void OnTriggerEnter(Collider other)

    {

        // LOGIKA SENSOR KERANJANG KOTOR

        if (sensorType == SensorType.DirtyBasket)

        {

            if (other.CompareTag("DirtyTowel"))

            {

                manager.OnDirtyTowelEnterBasket(other.gameObject);

            }

        }

        // LOGIKA SENSOR RAK BERSIH

        else if (sensorType == SensorType.CleanRack)

        {

            // Cek apakah handuk kotor SUDAH dibuang dulu? (Opsional, sesuai flow)

            // if (!manager.isDirtyTowelCleared) return;



            if (other.CompareTag("CleanTowel"))

            {

                // Cek apakah sedang dipegang? (Opsional: biar pas dilepas baru rapi)

                // Tapi request Anda "menyentuh 60% langsung rapi", jadi langsung saja:

                manager.OnCleanTowelEnterRack(other.gameObject);

            }

        }

    }

}