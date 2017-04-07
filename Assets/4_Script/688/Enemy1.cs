using UnityEngine;

public class Enemy1 : MonoBehaviour, IDestroyable, IMovable, IDamaged {

    [SerializeField] private GameObject _bomb;
    public int Hp { get; set; }
    public void Damage(int value) { Hp -= value; }

    public void Destroy()
    {
        Instantiate(_bomb);
        Destroy(gameObject);
    }

    public void MoveTo(Vector3 pos)
    {
        transform.position += pos;
    }

    void Start()
    {
        Hp = 5;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Damage(1);
            MoveTo(new Vector3(2f,0,0));
        }

        if (Hp < 0)
        {
            Destroy();
        }
    }

}