using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProgrammingMiniGame : MonoBehaviour
{
    //Reference from the editor
    [SerializeField]private TextMeshProUGUI quest;
    [SerializeField]private TextMeshProUGUI word1;
    [SerializeField]private TextMeshProUGUI word2;
    [SerializeField]private TextMeshProUGUI word3;
    [SerializeField]private TextMeshProUGUI word4;
    [SerializeField]private TextMeshProUGUI word5;
    [SerializeField]private TextMeshProUGUI word6;

    public List<TextMeshProUGUI> textMeshesPro;

    public List<string> wordsToFind;
    public List<string> wordsGuard;

    // Start is called before the first frame update
    void Start()
    {
        textMeshesPro.Add(word1);
        textMeshesPro.Add(word2);
        textMeshesPro.Add(word3);
        textMeshesPro.Add(word4);
        textMeshesPro.Add(word5);
        textMeshesPro.Add(word6);

        wordsToFind.Add("bool");
        wordsToFind.Add("void");
        wordsToFind.Add("CapsuleCollider2D");
        wordsToFind.Add("int");
        wordsToFind.Add("string");
        wordsToFind.Add("public");
        wordsToFind.Add("Physics2D");
        wordsToFind.Add("enum");
        wordsToFind.Add("print");
        wordsToFind.Add("NittBrain");
        wordsToFind.Add("Events");
        wordsToFind.Add("Array");
        wordsToFind.Add("float");
        wordsToFind.Add("if");
        wordsToFind.Add("ajax");
        wordsToFind.Add("GameObject");
        wordsToFind.Add("for");
        wordsToFind.Add("while");
        wordsToFind.Add("var");
        wordsToFind.Add("foreach");

        //add all items into the guard list
        foreach (var item in wordsToFind)
        {
            if (!wordsGuard.Contains(item))
            {
                wordsGuard.Add(item);
            }
        }

        ChooseRandomWord();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChooseRandomWord();
        }
    }

    void ChooseRandomWord()
    {
        bool hasTheQuestWord = false;

        //set the quest word
        int randomSelectionQuest = Random.Range(1, wordsToFind.Count + 1);
        quest.text = wordsToFind[randomSelectionQuest - 1];
        wordsToFind.Remove(wordsToFind[randomSelectionQuest - 1]);
        //set random words for each field
        foreach (var text in textMeshesPro)
        {
            int randomSelection = Random.Range(1, wordsToFind.Count + 1);
            text.text = wordsToFind[randomSelection - 1];
            wordsToFind.Remove(wordsToFind[randomSelection - 1]);
        }

        //when none of the words equals when the quest xd
        foreach (var text in textMeshesPro)
        {
            if (text.text == quest.text)
            {
                hasTheQuestWord = true;
            }
        }
        if (!hasTheQuestWord)
        {
            int randomTextMeshSelection = Random.Range(1, textMeshesPro.Count + 1);
            textMeshesPro[randomTextMeshSelection - 1].text = quest.text;
        }

        //return all values back to the word pool
        foreach (var item in wordsGuard)
        {
            if (!wordsToFind.Contains(item))
            {
                wordsToFind.Add(item);
            }
        }
    }
}
