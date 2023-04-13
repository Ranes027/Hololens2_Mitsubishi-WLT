using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MitsubishiAR.Components.Object.States
{
    public class ActiveStateComponent : MonoBehaviour
    {
        [SerializeField] private GameObject[] _objects;

        public void Active()
        {
            if (_objects != null)
                ChangeState(_objects);
            else
                Debug.Log("Add objects to ActiveStateComponent");
        }

        public static void ChangeState(GameObject[] objects)
        {
            for (int i = 0; i < objects.Length; i++)
            {
                if (objects[i].activeSelf == true)
                {
                    objects[i].SetActive(false);
                }
                else
                {
                    objects[i].SetActive(true);
                }
            }
        }
    }
}

