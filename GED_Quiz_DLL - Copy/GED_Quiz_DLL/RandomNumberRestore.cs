using System;
using UnityEngine;

namespace GED_Quiz_DLL
{
    public class RandomNumberRestore:MonoBehaviour
    {
        public GameObject m_gameObject;
        void Start()
        {
            Debug.Log("DLL works");
        }

        void Update()
        {
            m_gameObject.transform.position = new Vector3(0, 0, 0);
        }
    }
}
