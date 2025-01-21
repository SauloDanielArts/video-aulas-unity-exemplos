using UnityEngine;
using UnityEngine.Serialization;

public class ExplosaoParticula : MonoBehaviour
{
    public float forcaDaExposao = 150f;
    public float tempoDeVida = 1f;
    void Start()
    {
        Vector3 diracaoRandomica = new Vector3(
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f)
        );

        float forcaRandomica = Random.Range(0f, forcaDaExposao);
        
        GetComponent<Rigidbody>().AddForce(diracaoRandomica.normalized * forcaRandomica);
    }

    void Update()
    {
        tempoDeVida -= Time.deltaTime;
        if (tempoDeVida <= 0)
        {
            Destroy(gameObject);
        }
    }

    
}
