using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class Enemy : MonoBehaviour {

  private Rigidbody2D rb;

  void Start() {
    rb = gameObject.GetComponent<Rigidbody2D>();
  }

  void Update() {
    Move();
  }

  void OnTriggerEnter2D(Collider2D coll) {
    rb.velocity = Vector2.zero;
  }

  void OnTriggerStay2D(Collider2D coll) {
    rb.velocity = Vector2.zero;
  }

  private void Move() {
    float locationX = Random.Range(0, 9);
    float locationY = Random.Range(0, 8);
    Vector2 target = new Vector2(4,4);

    //transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), target, 3 * Time.deltaTime);
  }
}
