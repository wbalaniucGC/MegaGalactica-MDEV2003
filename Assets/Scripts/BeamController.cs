using UnityEngine;

public class BeamController : MonoBehaviour
{
    public float speed = 10.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(this.gameObject, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        MoveBeam();
    }

    private void MoveBeam()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
