using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameInfo.Accusation Solution;
    public static GameManager gameManager;

    public GameObject board;

    private List<Suspect> suspects;
    private List<Room> rooms;
    private List<Player> players;
    private List<GameInfo.Proof> proofs;

    private int turnIndex;

    private void Awake()
    {
        if(gameManager == null)
        {
            gameManager = this;
        }
    }

    public void StartGame()
    {
        turnIndex = 0;
        CreateSolution();
        PrepareProofs();
        DealProofs();

    }

    private void BuildRooms()
    {
        rooms = new List<Room>(board.GetComponentsInChildren<Room>());
        Debug.Log(rooms.Count);
    }

    public void EndOfTurn()
    {
        turnIndex++;
    }

    public void TurnGame()
    {

    }


    private void CreateSolution()
    {
        int room, prosecuted, gun;
        room = Random.Range(0, (int)GameInfo.ROOM_TYPE.NONE);
        prosecuted = Random.Range(0, (int)GameInfo.PROSECUTED.NONE);
        gun = Random.Range(0, (int)GameInfo.GUN_TYPE.NONE);

        Solution = new GameInfo.Accusation(
            (GameInfo.ROOM_TYPE)room, 
            (GameInfo.PROSECUTED)prosecuted, 
            (GameInfo.GUN_TYPE)gun);
    }

   

    private void PrepareProofs()
    {
        CreateSolution();
        proofs = GameInfo.CreateAllPendingProofs(Solution.room,Solution.prosecuted,Solution.gun);
    }
    
    private void DealProofs()
    {
        GameInfo.Proof proofAux;
        int playerIndex = 0;
        while(proofs.Count != 0)
        {
            int r = Random.Range(0, proofs.Count);
            proofAux = proofs[r];
            players[playerIndex].AddProof(proofAux);
            playerIndex++;
            playerIndex %= players.Count;
            proofs.RemoveAt(r);
        }
    }

    private bool CheckFormalAccusation(GameInfo.Accusation accusation)
    {
        return accusation == Solution;
    }

    public void EvaluateFormalAccusation(GameInfo.Accusation accusation, Player player)
    {
        if (CheckFormalAccusation(accusation))
        {
            Debug.Log("game finished");
        }
        else
        {
            Debug.Log("Fuck you, you miss");
        }
    }

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}
