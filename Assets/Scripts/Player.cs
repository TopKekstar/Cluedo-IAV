using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: MonoBehaviour
{

    public GamePiece gamePiece;

    private List<GameInfo.Proof> proofs;

    

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
        GameInfo.Accusation accusation = new GameInfo.Accusation(GameInfo.ROOM_TYPE.BAILE, GameInfo.PROSECUTED.AMAPOLA, GameInfo.GUN_TYPE.CANDELABRO);
        GameManager.gameManager.EvaluateFormalAccusation(accusation, this);

    }

    public void MoveToCell(RoomCell cell)
    {
        gamePiece.MoveToCell(cell);
    }

    public bool CheckAccusation(GameInfo.Accusation accusation) 
    {
        for(int i = 0; i< proofs.Count; i++)
        {
            if (accusation.HasProof(proofs[i]))
            {
                return true;
            }
        }
        return false;
    }


}
