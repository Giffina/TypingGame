using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WordGenerator : MonoBehaviour {
    static int index = -1;
    /*private static string[] wordList = { "sidewalk", "robin", "three", "protect", "periodic",
                                    "somber", "majestic", "jump", "pretty", "wound", "jazzy",
                                    "memory", "join", "crack", "grade", "boot", "cloudy", "sick",
                                    "mug", "hot", "tart", "dangerous", "mother", "rustic", "economic",
                                    "weird", "cut", "parallel", "wood", "encouraging", "interrupt",
                                    "guide", "long", "chief", "mom", "signal", "rely", "abortive",
                                    "hair", "representative", "earth", "grate", "proud", "feel",
                                    "hilarious", "addition", "silent", "play", "floor", "numerous",
                                    "friend", "pizzas", "building", "organic", "past", "mute", "unusual",
                                    "mellow", "analyse", "crate", "homely", "protest", "painstaking",
                                    "society", "head", "female", "eager", "heap", "dramatic", "present",
                                    "sin", "box", "pies", "awesome", "root", "available", "sleet", "wax",
                                    "boring", "smash", "anger", "tasty", "spare", "tray", "daffy", "scarce",
                                    "account", "spot", "thought", "distinct", "nimble", "practise", "cream",
                                    "ablaze", "thoughtless", "love", "verdict", "giant"};*/

    static TextAsset words = Resources.Load<TextAsset>("helloWorld");
    private static string[] wordList = words.text.Split(new char[] { ' ' });

    public static string ReadWords()
    {
        if (index < wordList.Length)
            index = index + 1;
        else if (index == wordList.Length)
            index = -1;
        else
            index = index + 1;
        string wordsRead = wordList[index];

        return wordsRead;
    }

    /*public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }*/
}
