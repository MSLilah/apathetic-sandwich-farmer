using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

  public float playerSpeed;

  private Rigidbody2D rb;

  void Start() {
    rb = gameObject.GetComponent<Rigidbody2D>();
  }
	// Update is called once per frame
	void Update () {
    Move ();
	}

  private void Move() {
    float velocityX = Input.GetAxisRaw ("Horizontal") * playerSpeed;
    float velocityY = Input.GetAxisRaw ("Vertical") * playerSpeed;

    rb.velocity = new Vector2 (velocityX, velocityY);
  }
}
