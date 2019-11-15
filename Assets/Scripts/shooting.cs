using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public GameObject pref;
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject buffer = Instantiate<GameObject>(pref);
            buffer.transform.position = transform.position;
            buffer.GetComponent<Rigidbody>().AddForce(transform.forward.normalized * force);
        }
    }

}
