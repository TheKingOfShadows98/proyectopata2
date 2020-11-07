using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ProgrammingMiniGameWordsColliders : MonoBehaviour
{
    public TextMeshProUGUI myTextMesh;
    public TextMeshProUGUI questTextMesh;

    public Color hoverColor;
    public Color normalColor;

    private void Start()
    {
        myTextMesh = GetComponent<TextMeshProUGUI>();
        questTextMesh = GameObject.FindGameObjectWithTag("ProgrammingGame_Quest").GetComponent<TextMeshProUGUI>();

        normalColor = myTextMesh.color;
    }

    private void OnMouseDown()
    {
        if (myTextMesh.text == questTextMesh.text)
        {
            print("VAMO LOS PIBEEEE");
        }
        else
        {
            print("PERDISTE ASSHOLE");
        }
    }

    private void OnMouseEnter()
    {
        myTextMesh.color = hoverColor;
    }

    private void OnMouseExit()
    {
        myTextMesh.color = normalColor;
    }
}
