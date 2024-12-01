using UnityEngine;

public class TestPlayer2 : MonoBehaviour
{
    [SerializeField] Transform target;
    Vector2 lastRotation;

    // Update is called once per frame
    void Update()
    {
        // gameObject.transform.LookAt(target);

        Vector2 direction = target.position - transform.position;

        if(lastRotation != direction)
        {
            transform.rotation = Quaternion.FromToRotation(Vector3.up, direction);
            Debug.Log("test");
        }
        lastRotation = direction;
    }
}
