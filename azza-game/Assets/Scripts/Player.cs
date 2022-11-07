using UnityEngine;

public class Player : MonoBehaviour
{
  public float ForceAmount = 4f;
  public Rigidbody rb;
  public Animator anim;
  void Start()
  {

  }
  void Update()
  {
    PlayerAnimation();
  }

  void FixedUpdate()
  {
    PlayerMovement();
  }

  void PlayerMovement()
  {
    // Forma 2
    float h = Input.GetAxis("Horizontal") * ForceAmount * Time.fixedDeltaTime;
    float v = Input.GetAxis("Vertical") * ForceAmount * Time.fixedDeltaTime;
    rb.AddForce(new Vector3(ForceAmount * h, 0, 0), ForceMode.Impulse);
    rb.AddForce(new Vector3(0, 0, ForceAmount * v), ForceMode.Impulse);
    if (Input.GetKeyDown(KeyCode.Space)) rb.AddForce(new Vector3(0, ForceAmount * 1.2f, 0), ForceMode.Impulse);
  }

  void PlayerAnimation()
  {
    if (Input.GetKeyDown(KeyCode.W))
    {
      anim.SetBool("isRunning", true);
    }
    if (Input.GetKeyUp(KeyCode.W))
    {
      anim.SetBool("isRunning", false);
    }

    if (Input.GetKeyDown(KeyCode.S))
    {
      anim.SetBool("isWalkingBack", true);
    }
    if (Input.GetKeyUp(KeyCode.S))
    {
      anim.SetBool("isWalkingBack", false);
    }
  }

}
