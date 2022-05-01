using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HongObjectPooling
{
    public class CubeSpawner : MonoBehaviour
    {
        public GameObject SpawnObject;
        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine("Spawn");
        }

        IEnumerator Spawn()
        {
            yield return new WaitForSeconds(0.01f);
            Instantiate(SpawnObject);
            StartCoroutine("Spawn");
        }
    }
}