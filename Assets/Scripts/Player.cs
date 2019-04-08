using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: MonoBehaviour
{

    public GamePiece gamePiece;

    private void Awake()
    {
        gamePiece = GetComponent<GamePiece>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MakeAccusation()
    {

    }

    public void MakeFormalAccusation()
    {

    }

    public void MoveToCell(RoomCell cell)
    {
        gamePiece.MoveToCell(cell);

    }
}
