using UnityEngine;
using System.Collections;

public class Player : Actor {

  public float playerSpeed;

  protected override void Start() {
    base.Start();
  }

  void Update () {
    Move();
  }

  private void Move() {
    float velocityX = Input.GetAxisRaw ("Horizontal") * playerSpeed;
    float velocityY = Input.GetAxisRaw ("Vertical") * playerSpeed;

    base.Move(velocityX, velocityY);
  }
}
