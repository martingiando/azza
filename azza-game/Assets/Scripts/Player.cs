using UnityEngine;

public class Player : MonoBehaviour
{
  public float ForceAmount = 4f;
  public Rigidbody rb;
  public Animator anim;

  public float life = 100f;

  Vector3 posInicial;

  
  void Start()
  {
    posInicial = transform.position;
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

  void Respawn()
  {
    transform.position = posInicial;
    life = 100f;
  }

  private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bala")
    {
      life -= 50f;
      Debug.Log("The Player has been hit!");
      Destroy(other.gameObject);
      if (life <= 0)
      {
        Respawn();
        Debug.Log("Game Over!");
      }
    }

       if (other.gameObject.tag == "BalaHall")
    {
      life -= 30f;
      Debug.Log("The Player has been hit!");
      Destroy(other.gameObject);
      if (life <= 0)
      {
        Respawn();
        Debug.Log("Game Over!");
      }
    }
     }



  private void OnTriggerEnter(Collider other){
    if (other.gameObject.tag == "Coin")
    {
      Destroy(other.gameObject);
      Debug.Log("You got a coin!");
    }
  }

}
