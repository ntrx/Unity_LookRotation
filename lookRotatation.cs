using UnityEngine;

public class lookRot : MonoBehaviour
{
    RaycastHit hit;
    Transform _followThis;
    public bool isTracking = false;
    public bool isHit = false;


    // Update is called once per frame
    void FixedUpdate()
    {
        if (isTracking) {
            Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 1000f);
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);

            if (hit.collider != null)
                _followThis = hit.collider.transform;
            if (hit.collider.tag == "target")
                isHit = true;
            else
                isHit = false;

            if (isHit) {
                Vector3 relPos = _followThis.position - transform.position;
                Quaternion lRot = Quaternion.LookRotation(relPos);
                transform.rotation = lRot;
            }
            
        }
    }
}
