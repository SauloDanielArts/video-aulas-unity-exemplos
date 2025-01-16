using UnityEngine;

public class Bala : MonoBehaviour
{
    public float forcaDoTiro = 10;
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.forward * forcaDoTiro);
    }

    void Update()
    {
        
    }
}
