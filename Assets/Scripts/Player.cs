using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

  public float playerSpeed;

  private Rigidbody2D rb;

  void Start() {
    rb = gameObject.GetComponent<Rigidbody2D>();
  }

  void Update () {
    Move ();
  }

  void OnTriggerEnter2D(Collider2D coll) {
    rb.velocity = Vector2.zero;
  }

  void OnTriggerStay2D(Collider2D coll) {
    rb.velocity = Vector2.zero;
  }

  private void Move() {
    float velocityX = Input.GetAxisRaw ("Horizontal") * playerSpeed;
    float velocityY = Input.GetAxisRaw ("Vertical") * playerSpeed;

    rb.velocity = new Vector2 (velocityX, velocityY);
  }
}
