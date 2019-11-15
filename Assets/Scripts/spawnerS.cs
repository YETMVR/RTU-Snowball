using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerS : MonoBehaviour
{

    public GameObject[] sp = new GameObject[8];
    public GameObject pref;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Spawn()
    {
        GameObject spawnPoint = sp[Random.Range(0, 8)];

        GameObject buffer = Instantiate<GameObject>(pref);
        buffer.transform.position = spawnPoint.transform.position;
    }
}
