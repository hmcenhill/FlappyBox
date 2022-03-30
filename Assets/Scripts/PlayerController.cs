using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Vector2 jumpPower = Vector2.up * 5f;
    [SerializeField] private float recoverSpeed = 0.2f;
    private Rigidbody2D rb;

    private bool playing = false;

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (playing)
        {
            if (this.transform.position.x < 0f)
            {
                MoveForward();
            }

            //TODO: Change input control
            if (Input.GetButtonDown("Fire1"))
            {
                Jump();
            }
        }
        else
        {
            this.transform.position = Vector3.zero;
            if (Input.GetButtonDown("Fire1"))
            {
                GameManager.Instance.StartGame();
                Jump();
            }
        }
    }

    public void StartGame() => playing = true;
    public void StopGame() => playing = false;

    private void Jump()
    {
        rb.velocity = jumpPower;
    }

    private void MoveForward()
    {
        this.transform.position += Vector3.right * Time.deltaTime * recoverSpeed;
    }
}