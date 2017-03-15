using UnityEngine;

public class Run : IState
{

    private readonly float _speed;

    public Run(float speed)
    {
        _speed = speed;
    }

    public void Move()
    {
        Debug.Log("speedA = " + _speed + "で走ってます" );
    }
}
