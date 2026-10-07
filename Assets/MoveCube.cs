using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        // キューブを前方に動かす        
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
