using UnityEngine;

public class BoulderCheck : MonoBehaviour
{
    public GameObject gate;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gate);
    }
}
