using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Position : MonoBehaviour
{
    public GameObject m_gameObject;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        m_gameObject.transform.position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
    }
}
