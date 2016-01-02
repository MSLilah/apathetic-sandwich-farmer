using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class Enemy : Actor {

  public float walkSpeed = 5.0f;

  private Vector3 walkAmount;

  private Transform player;

  protected override void Start() {
    player = GameObject.FindGameObjectWithTag("Player").transform;

    base.Start();
  }

  void Update() {
    Move();
  }

  private void Move() {
    Vector3 playerTarget = player.position;

    transform.position = Vector3.MoveTowards(new Vector3(transform.position.x, transform.position.y, 0f), playerTarget, 3 * Time.deltaTime);
  }
}
