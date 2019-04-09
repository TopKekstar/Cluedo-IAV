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
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
