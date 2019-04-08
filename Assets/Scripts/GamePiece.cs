using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePiece : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
    }
}
