using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI[] dialogueText;
    public Image daughterImage;

    Queue<string> sentences;
    Queue<Image> daughters; 

    [SerializeField] GameObject truth;
    [SerializeField] GameObject lie;
    [SerializeField] GameObject startDialogue;
    void Start()
    {
        sentences = new Queue<string>();
        daughters = new Queue<Image>();

        truth.SetActive(false);
        lie.SetActive(false);
    }

    public void StartDialogue(Dialogue dialogue)
    {
        sentences.Clear();
        daughters.Clear();

        truth.SetActive(true);
        lie.SetActive(true);
        startDialogue.GetComponent<Button>().interactable = false;

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        foreach(Image daughter in dialogue.daughters)
        {
            daughters.Enqueue(daughter);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }


        string sentence = sentences.Dequeue();
        Image daughter = daughters.Dequeue();

        for (int i = 0; i < dialogueText.Length; i++)
        {
            dialogueText[i].text = sentence;
        }
 
        daughterImage.sprite = daughter.sprite;

    }

    void EndDialogue()
    {
        SceneManager.LoadScene(16);
    }
}
    
