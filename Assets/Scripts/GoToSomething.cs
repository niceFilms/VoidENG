using UnityEngine;

public class GoToSomething : MonoBehaviour {

    public Transform player;
    public PlayerMovement playerobj;
    public Vector3 Offset;
    public Rigidbody RB;
    public float multiply = 1f;
    Vector3 lgma;

    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = player.position + Offset;
        lgma = new Vector3 (playerobj.x, playerobj.y, playerobj.z);
        lgma.Normalize();
        //RB.velocity = new Vector3 (playerobj.x * multiply, playerobj.y * multiply, playerobj.z * multiply);
        RB.velocity = new Vector3 (lgma.x * multiply, lgma.y * multiply, lgma.z * multiply);
    }
}
