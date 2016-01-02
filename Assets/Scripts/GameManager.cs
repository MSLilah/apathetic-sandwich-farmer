using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

  private BoardManager boardManager;

  private List<Enemy> enemies;

  void InitGame() {
    boardManager.GenerateBoard();
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
