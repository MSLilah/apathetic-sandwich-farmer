using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class Enemy : Actor {

  void Start() {
    base.Start();
  }

  void Update() {
    Move();
  }

  private void Move() {
    float locationX = Random.Range(0, 9);
    float locationY = Random.Range(0, 8);
    Vector2 target = new Vector2(4,4);

    //transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), target, 3 * Time.deltaTime);
  }
}
