using UnityEngine;

public class TestPlayer : MonoBehaviour
{
    float _moveSpeed = 10f;
    float _rotateSpeed = 200f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.Translate(new Vector2(0f, _moveSpeed) * Time.deltaTime, Space.Self);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Rotate(new Vector3(0f, 0f, _rotateSpeed) * Time.deltaTime, Space.Self);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Rotate(new Vector3(0f, 0f, -_rotateSpeed) * Time.deltaTime, Space.Self);
        }

    }
}
