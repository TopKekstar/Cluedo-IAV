using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePiece : MonoBehaviour
{
    private Room room;

    public bool IsThisYourRoom(Room r)
    {
        return r == room;
    }

    public void MoveToCell(RoomCell roomCell, System.Action<GamePiece> onArrive = null )
    {
        StartCoroutine(MoveToCellCoroutine(roomCell, onArrive));

    }

    IEnumerator MoveToCellCoroutine(RoomCell roomCell, System.Action<GamePiece> onArrive = null)
    {
        yield return new WaitForEndOfFrame();
        if (onArrive != null)
            onArrive(this);
        roomCell.FillCell(this);
        room = roomCell.room;
    }
}
