using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Floor") {
            GetComponent<MeshRenderer>().material.color = Color.blue;
        }
    }
}
