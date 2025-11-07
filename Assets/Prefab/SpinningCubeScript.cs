using UnityEngine;

public class SpinningCubeScript : MonoBehaviour
{
    public Transform Cube;
    public float speed = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cube.Rotate(0, speed * Time.deltaTime, 0);
    }
}
