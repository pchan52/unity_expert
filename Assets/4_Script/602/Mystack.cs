using UnityEngine;

public class Mystack<T> {
     private int _top;
     private readonly T[] _mystack;

     public Mystack(int max)
     {
         _mystack = new T[max];
         this._top = 0;
     }

     public void Push(T x){
         this._mystack[this._top++] = x;
     }

     public T Pop(){
         return this._mystack[--this._top];
     }

     public void ShowStack(){
         for (var i = 0; i < _top; i++) {
             Debug.Log (_mystack [i]);
         }
     }
 }

