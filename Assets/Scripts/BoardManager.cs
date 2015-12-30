using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BoardManager : MonoBehaviour {

  private List<Vector3> gridPositions = new List<Vector3>();

  // Either top or bottom row will be UI for game
  //   so game board is technically 9x9
  private int columns = 9;
  private int rows = 10;

  void InitializeList() {
    gridPositions.Clear();

    for (int i  = 0; i <= columns; i++) {
      for (int j = 0; j <= rows; j++) {
        gridPositions.Add(new Vector3(i, j, 0f));
      }
    }
  }

  void SetupBoard() {
    InitializeList();

  }

  public void GenerateBoard() {
    SetupBoard();

  }
}
