using UnityEngine;

public class Enemy2 : MonoBehaviour, IMovable {

    [SerializeField] private GameObject _bomb;
    public void MoveTo(Vector3 pos) { transform.position += pos; }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MoveTo(new Vector3(1f,0,0));
        }
    }
}