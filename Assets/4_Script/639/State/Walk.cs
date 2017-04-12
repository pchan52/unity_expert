using UnityEngine;

public class Walk : IState {

    private readonly float _speed;

    public Walk(float speed)
    {
        _speed = speed;
    }

    public void Move()
    {
        Debug.Log("speedB = " + _speed + "で歩いています");
    }

}
