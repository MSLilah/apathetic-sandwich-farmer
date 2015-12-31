using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

  private BoardManager boardManager;

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
