using System;
using UnityEngine;

namespace GED_Quiz_DLL
{
    public class RandomNumber:MonoBehaviour
    {
        public GameObject m_gameObject;
        void Start()
        {
            Debug.Log("DLL works");
        }

        void Update()
        {
            m_gameObject.transform.position = new Vector3(UnityEngine.Random.Range(-10.0f, 10.0f), 0, UnityEngine.Random.Range(-10.0f, 10.0f));
        }
    }
}
