using UnityEngine;

public class DetectorMeta : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Jugador llegó a la meta");
        }
    }
}
