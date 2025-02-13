using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject platformPrefab;

    public int numberOfPlatforms = 200;
    public float levelWidth = 3f;
    public float minY = .2f;
    public float maxY = 1.5f;


    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for(int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth,levelWidth);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
