using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suspect : MonoBehaviour
{
    private GameInfo.PROSECUTED id;
    private GamePiece gamePiece;

    public void MoveToCell(RoomCell cell, System.Action<GamePiece> onArrive = null )
    {
        gamePiece.MoveToCell(cell,onArrive);
    }

    public bool IsThisYourRoom(Room r)
    {
        return gamePiece.IsThisYourRoom(r);
    }

    private void Awake()
    {
        gamePiece = GetComponent<GamePiece>();
        
    }
}
