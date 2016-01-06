using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

  private BoardManager boardManager;

  private List<Enemy> enemies;

  public GameObject player;
  public GameObject enemy;

  void InitGame() {
    boardManager.GenerateBoard();
    Instantiate(player, new Vector3(2.0f, 4.0f, 0f), Quaternion.identity);

    Instantiate(enemy, new Vector3(5.0f, 9.0f, 0f), Quaternion.identity);
  }

  void Update() {
  }

  void GameOver() {
  }

  void Awake() {
    boardManager = GetComponent<BoardManager>();
    InitGame();
  }

}
