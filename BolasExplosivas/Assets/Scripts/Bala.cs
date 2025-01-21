using UnityEngine;

public class Bala : MonoBehaviour
{
    public float forcaDoTiro = 10;
    public Vector3 direcaoDoTiro;
    public GameObject explosaoPrefab;
    
    
    public float tempoDeVida = 3f;
    void Start()
    {
        //GetComponent<Rigidbody>().AddForce(Vector3.forward * forcaDoTiro);
        GetComponent<Rigidbody>().AddForce(direcaoDoTiro * forcaDoTiro);
    }
    

    void Update()
    {
        tempoDeVida -= Time.deltaTime;
        if (tempoDeVida <= 0)
        {
            Destroy(gameObject);
        }
    }
    
    
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colodiu com a parede!!! "+collision.gameObject.name+" "+collision.gameObject.tag);
        
        if (collision.gameObject.CompareTag("TreiggerExplosion"))
        {
            GameObject explosaoObjeto = Instantiate(explosaoPrefab, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
