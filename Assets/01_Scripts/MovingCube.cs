using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HongObjectPooling
{
    public class MovingCube : MonoBehaviour
    {
        private Vector3 direction;
        // Start is called before the first frame update
        void Start()
        {
            direction = new Vector3(Random.Range(-0.1f, 0.1f),
                Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f));
            StartCoroutine("DestroyObject");
        }

        private void FixedUpdate()
        {
            transform.position += direction;
        }

        IEnumerator DestroyObject()
        {
            yield return new WaitForSeconds(4.0f);
            Destroy(gameObject);
        }
    }
}