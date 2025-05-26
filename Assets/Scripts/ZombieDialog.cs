using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ZombieDialog : MonoBehaviour
{
    public TMP_Text dialogueText;

    public List<string[]> groanLines = new List<string[]>();

    void Start()
    {
       
        string[] set1 = { "ahh", "aah", "ugh" };
        string[] set2 = { "grr", "raah", "nghh" };
        groanLines.Add(set1);
        groanLines.Add(set2);

        StartCoroutine(ZombieGroanLoop());
    }

    IEnumerator ZombieGroanLoop()
    {
        while (true)
        {
            for (int i = 0; i < groanLines.Count; i++)
            {
                string[] currentSet = groanLines[i];
                for (int j = 0; j < currentSet.Length; j++)
                {
                    dialogueText.text = currentSet[j];
                    yield return new WaitForSeconds(2f);
                }
            }
        }
    }
}
