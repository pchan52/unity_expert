using System;
using System.Collections;
using System.Collections.Generic;

public class LetterFactory  {

    readonly Dictionary<char, CharLetter> _list = new Dictionary<char, CharLetter>();

    //create Singleton
    private static readonly LetterFactory Singleton = new LetterFactory();

    //Singleton pattern
    public LetterFactory()
    {
    }

    public LetterFactory GetInstance()
    {
        return Singleton;
    }

    public CharLetter GetLetter(char c)
    {
        if (_list.ContainsKey(c)) return _list[c];     //keyがあればvalueを返す
        var unUsedletter = new CharLetter(c);  //なければ生成する
        _list.Add(c, unUsedletter);

        return unUsedletter;
    }
}


