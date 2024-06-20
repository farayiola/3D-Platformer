using UnityEngine;

public class GemRotate : MonoBehaviour
{
    public int rotateSpeed = 2;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotateSpeed * Time.timeScale, 0, Space.World);

    }
}
