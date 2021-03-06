﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WordManager : MonoBehaviour {

    public List<Word> words;

    public WordSpawner wordSpawner;
    
    private bool hasActiveWord;
    public Word activeWord;
    public AudioSource Nice;

    public void AddWord()
    {
        Word word = new Word(WordGenerator.ReadWords(), wordSpawner.SpawnWord());
        Debug.Log(word.word);

        words.Add(word);
    }
    public void PlayNice()
    {
        Nice.Play();
    }
    public void TypeLetter(char letter)
    {
        if(hasActiveWord)
        {
            if(activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }
        }
        else
        {
            foreach(Word word in words)
            {
                if (word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }
        if (hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            words.Remove(activeWord);
            ScoreScirpt.scoreValue += 1;
            PlayNice();

        }


    }




}
