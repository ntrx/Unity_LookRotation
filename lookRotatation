using UnityEngine;

public class lookRot : MonoBehaviour
{
    RaycastHit hit;
    Transform _followThis;

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 1000f)) {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);

            this._followThis = hit.collider.transform;

            Vector3 relPos = this._followThis.position - transform.position;
            Quaternion lRot = Quaternion.LookRotation(relPos);
            transform.rotation = lRot;
        }
    }
}
