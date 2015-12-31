using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BoardManager : MonoBehaviour {

  // Private vars

  private List<Vector3> gridPositions = new List<Vector3>();
  private Transform boardTransform;

  // Either top or bottom row will be UI for game
  //   so game board is technically 9x9
  private int columns = 9;
  private int rows = 10;

  // Public vars

  public GameObject WallUpperLeft;
  public GameObject WallLowerLeft;
  public GameObject WallUpperRight;
  public GameObject WallLowerRight;
  public GameObject WallLeft;
  public GameObject WallRight;
  public GameObject WallUpper;
  public GameObject WallLower;
  public GameObject Floor1;

  // For random things that go on the gameboard
  // that aren't tiles
  void InitializeList() {
    gridPositions.Clear();

    for (int i  = 0; i <= columns; i++) {
      for (int j = 0; j <= rows; j++) {
        gridPositions.Add(new Vector3(i, j, 0f));
      }
    }
  }

  GameObject DetermineTile(int i, int j) {
    Debug.Log("DetermineTile: " + i + "," + j);
    if (i == 0 && j == 0) {
      // wall lower left
      //Debug.Log("Wall Lower Left");
      return WallLowerLeft;
    }
    else if (i == 0 && j == rows) {
      // wall Upper left
      //Debug.Log("Wall Upper Left");
      return WallUpperLeft;
    }
    else if (i == columns && j == 0) {
      // wall lower right
      //Debug.Log("Wall Lower Right");
      return WallLowerRight;
    }
    else if (i == columns && j == rows) {
      // wall upper right
      //Debug.Log("Wall Lower Right");
      return WallUpperRight;
    }
    else if (i == 0 && j < rows) {
      // wall left
      //Debug.Log("Wall Left");
      return WallLeft;
    }
    else if (i < columns  && j == 0) {
      // wall lower
      Debug.Log("Wall Lower");
      return WallLower;
    }
    else if (i == columns && j < rows) {
      // wall right
      //Debug.Log("Wall Right");
      return WallRight;
    }
    else if (i > 0 && j == rows) {
      // wall Upper
      Debug.Log("Wall Upper");
      return WallUpper;
    }
    else {
      // Floor_1
      Debug.Log("Floor 1");
      return Floor1;
    }
  }

  void SetupBoard() {
    boardTransform = new GameObject("Board").transform;

    // 9
    // |
    // |
    // |
    // 0 - - 8
    //
    for (int i  = 0; i <= columns; i++) {
      for (int j = 0; j <= rows; j++) {
        GameObject instObj;

        instObj = DetermineTile(i, j);

        GameObject instance = Instantiate(instObj,
                                new Vector3(i, j, 0f), Quaternion.identity) as GameObject;
        instance.transform.SetParent(boardTransform);
      }
    }

  }

  public void GenerateBoard() {
    SetupBoard();
    InitializeList();
  }
}
