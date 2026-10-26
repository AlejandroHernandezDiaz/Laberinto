using UnityEngine;

public class Rotador : MonoBehaviour
{
    [SerializeField]
    float rotacionY = 10f;
    void Update()
    {
        transform.Rotate(0.0f, rotacionY * Time.deltaTime, 0.0f);
    }
}
