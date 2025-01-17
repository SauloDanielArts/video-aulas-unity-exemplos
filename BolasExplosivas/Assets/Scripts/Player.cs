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
           GameObject objetoBala = Instantiate(balaPrefab, transform.position, transform.rotation);
           Bala bala = objetoBala.GetComponent<Bala>();
               
           //bala.direcaoDoTiro = Vector3.forward;
           bala.direcaoDoTiro = transform.forward;
           
           //Vector3 direcaoDoTiro = bala.direcaoDoTiro;
           
            Vector3 direcaoDoTiro = new Vector3(
               transform.position.x + Random.Range(-0.25f,0.25f),
               transform.position.y + Random.Range(-0.2f,0.2f),
               transform.position.z + 1);
            
            bala.transform.position = direcaoDoTiro;
        }
    }
}
