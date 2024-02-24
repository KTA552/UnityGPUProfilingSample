using UnityEngine;

namespace _Example.Scripts
{
    internal class Rotation : MonoBehaviour
    {
        [SerializeField] private float speed;

        private void Update()
        {
            transform.Rotate(Vector3.up, speed * Time.deltaTime);
        }
    }
}
