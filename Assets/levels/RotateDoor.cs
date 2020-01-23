using System;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
    public class RotateDoor : MonoBehaviour
    {
        public KeyCode pressUp;
        public KeyCode pressDown;
        public KeyCode pressLeft;

        private void Start()
        {
          //  m_LastRealTime = Time.realtimeSinceStartup;
           
        }


        // Update is called once per frame
        private void Update()
        {
            Debug.Log(GetComponent<Transform>().eulerAngles);
            if (Input.GetKeyDown(pressUp))
                GetComponent<Transform>().eulerAngles = new Vector3(270, 0,90);
            if (Input.GetKeyDown(pressDown))
                GetComponent<Transform>().eulerAngles = new Vector3(270, 0, -90);
            if (Input.GetKeyDown(pressLeft))
                GetComponent<Transform>().eulerAngles = new Vector3(270, 0, 0);
        }


        [Serializable]
        public class Vector3andSpace
        {
            public Vector3 value;
            public Space space = Space.Self;
        }
    }
}
