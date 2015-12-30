using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BoardManager : MonoBehaviour {

  private List<Vector3> gridPositions = new List<Vector3>();

  private int columns = 10;
  private int rows = 9;

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
