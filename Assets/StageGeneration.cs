using UnityEngine;
using System.Collections;

public class StageGeneration : MonoBehaviour
{
    public GameObject pattern1;
    public GameObject pattern2;
    public GameObject pattern3;
    public GameObject[] obj;
    public float spawnMin = 1f;
    public float spawnMax = 2f;
    public Vector3 pos = new Vector3(0, 0, 0);
    public float size = 1.0f;
    private Vector3 dir = new Vector3(0, -30, 0);
    // Use this for initialization
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            int r;
            r = Random.Range(1, 4);
            if (r == 1)
                Instantiate(pattern1, pos, Quaternion.identity);
            if (r == 2)
                Instantiate(pattern2, pos, Quaternion.identity);
            if (r == 3)
                Instantiate(pattern3, pos, Quaternion.identity);


            pos += dir * size;
            yield return new WaitForSeconds(Random.Range(spawnMin, spawnMax));
        }
    }

    //void CallRandom()
    //{
    //    int r;
    //    r = Random.Range(1, 4);

    //    if (r == 1) Instantiate(pattern1);
    //    if (r == 2) Instantiate(pattern2);
    //    if (r == 3) Instantiate(pattern3);


    //}
}