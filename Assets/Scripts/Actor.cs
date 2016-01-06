using UnityEngine;
using System.Collections;

public abstract class Actor : MonoBehaviour {

  private Rigidbody2D rb;
  private Animator anim;

  // Use this for initialization
  protected virtual void Start () {
    rb = gameObject.GetComponent<Rigidbody2D>();
    anim = gameObject.GetComponent<Animator>();
  }
  // Update is called once per frame
  void Update () {
  }

  // Collision detection
  void OnTriggerEnter2D(Collider2D coll) {
    rb.velocity = Vector2.zero;
  }

  // Collision detection
  void OnTriggerStay2D(Collider2D coll) {
    rb.velocity = Vector2.zero;
  }

  protected virtual void Move(float velocityX, float velocityY) {
    Vector2 velocity = new Vector2(velocityX, velocityY);
    rb.velocity = velocity;

    anim.SetBool("Moving", velocity.magnitude > 0);
  }

  protected virtual void Attack() {
  }

  protected Animator GetAnim() {
    return anim;
  }
}
