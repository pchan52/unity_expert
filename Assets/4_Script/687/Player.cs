using System;
using UnityEngine;

public interface IPlayerState
{
	void Move();
}

public class Run : IPlayerState
{
	private readonly Vector3 _velocity;
	private readonly Transform _transform;

	public Run(Vector3 velocity, Transform transform)
	{
		_velocity = velocity;
		_transform = transform;
	}

	public void Move()
	{
		_transform.position += _velocity * 3;
	}

	void Update(){
		
	}
}
public class Walk : IPlayerState
{
	private readonly Vector3 _velocity;
	private readonly Transform _transform;

	public Walk(Vector3 velocity, Transform transform)
	{
		_velocity = velocity;
		_transform = transform;
	}

	public void Move()
	{
		_transform.position += _velocity;
	}
}
public class Wait : IPlayerState
{
	public void Move()
	{
		// Do nothing
	}
}

public class Player : MonoBehaviour
{
	[SerializeField] private Vector3 _velocity;
	private IPlayerState _state;
	private float time = 0;
	private bool Isruning = true;

	public void Awake()
	{
		_state = new Run(_velocity, transform);
	}
	public void Update()
	{
		_state.Move();
		time += Time.deltaTime;
		if (time > 5f ) {
			if (Isruning) {
				_state = new Walk (_velocity * 0.5f, transform);
				Isruning = false;
			} else {
				_state = new Run (_velocity, transform);
				Isruning = true;
			}
			time = 0;
		}
	}
}