using UnityEngine;

public class bird : MonoBehaviour
{
    private Rigidbody2D myRigidbody;
    public float jumpForce = 10f;
    public logicscript logic;
    public bool birdsAlive = true;


    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicscript>();
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& birdsAlive )
        {
            Debug.Log("Space Pressed");
            myRigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdsAlive = false;
    }
}
