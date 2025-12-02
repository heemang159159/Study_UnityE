using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject targetPrefab;
    public Transform spawnPosition;

    public void  SpawnTarget()
    {
        //Instantiate(targetPrefab);
        //Instantiate(targetPrefab, Vector3.zero, Quaternion.identity);
        Instantiate(targetPrefab, transform.position, Quaternion.identity);
    }


}
