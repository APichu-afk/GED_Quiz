using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No_Rndom : MonoBehaviour
{
    public GameObject m_gameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_gameObject.transform.position = new Vector3(0, 0, 0);
    }
}
