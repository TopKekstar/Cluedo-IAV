using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameInfo.Accusation Solution;
    public static GameManager gameManager;

    private List<Suspect> suspects;
    private List<Room> rooms;
    private List<Player> players;

    private void Awake()
    {
        if(gameManager == null)
        {
            gameManager = this;
        }
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

    private void CreateProofs()
    {
        
        
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

        UnityEngine.UI.Dropdown kek;
        
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}
