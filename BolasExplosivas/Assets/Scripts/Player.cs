using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject balaPrefab;
    
    void Start()
    {
        
    }
 void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(balaPrefab);
        }
    }
}
