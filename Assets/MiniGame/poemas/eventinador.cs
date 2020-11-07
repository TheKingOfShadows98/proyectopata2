using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

public class eventinador : MonoBehaviour
{
    public int max = 10;
    public Action Activate;
    public static eventinador events;
    public List<GameObject> MiniGames;
    public GameObject ActiveGame;
    // Start is called before the first frame update
    void Awake()
    {
        if(MiniGames.Count > 0)
        {
            GetRandomGame();
            ActivarJuego();
        }
        events = this;
        Activate += Sum;
    }

    // Update is called once per frame
    void Update()
    {
        if(max < 1)
        {
            CambiarJuego();
        }
    }

    public void OnActivate()
    {
        if(Activate != null)
        {
            Activate.Invoke();
        }
    }
    private void CambiarJuego()
    {
        Destroy(ActiveGame);
        GetRandomGame();
        ActivarJuego();
        max = 10;
    }

    private void GetRandomGame()
    {
        if(MiniGames.Count > 0) { 
        int rand = Random.Range(0, MiniGames.Count);
        ActiveGame = MiniGames[rand];
        MiniGames.RemoveAt(rand);
        }
        else
        {
            Debug.Log("Haz Ganado XD LUL");
        }

    }
    private void ActivarJuego()
    {
        ActiveGame.SetActive(true);
    }

    private void Sum()
    {
        max--;
    }
}
