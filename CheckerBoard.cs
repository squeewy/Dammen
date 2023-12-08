using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckerBoard : MonoBehaviour
{
    public CheckersPiece[,] pieces = new CheckersPiece[8, 8];
    public GameObject whitePiecePrefab;
    public GameObject blackPiecePrefab;

    private void GenerateBoard()
    {
        // genereer team wit
        for (int y = 0; y < 3; y++)
        {
            for(int x = 0; x < 8; x+=2)
            {
              //genereer dammenstukken
              GeneratePiece(x,y);  
            }
        }
    }

    private void GeneratePiece(int x, int y)
    {
        GameObject go = Instantiate(whitePiecePrefab) as GameObject;
        go.transform.SetParent(transform);
        CheckersPiece p = go.GetComponent<CheckersPiece>();
        pieces[x, y] = p;
    }

    // Start is called before the first frame update
    private void Start()
    {
        GenerateBoard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
