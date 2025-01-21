using UnityEngine;

public class Explosao : MonoBehaviour
{
    
    public GameObject[] particulasPrefabs;
    public int numeroDeParticulas = 3;
    
    void Start()
    {
        for (int i = 0; i < numeroDeParticulas; i++)
        {
            GameObject particulasPrefab = Instantiate(particulasPrefabs[Random.Range(0, particulasPrefabs.Length)]);
            particulasPrefab.transform.position = transform.position;
        }
    }

    
    void Update()
    {
        
    }
}
