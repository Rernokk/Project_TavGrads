using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActor : AbstractActor
{
	#region Serialize Fields
	[Header("Movement")]
	[SerializeField]
	[Tooltip("How quickly the player moves (float).")]
	private float moveSpeed;

	[SerializeField]
	[Tooltip("The maximum run speed of the player (float).")]
	private float maxMoveSpeed;

	[SerializeField]
	[Tooltip("How much the player's run speed increases when the associated timer expires (float).")]
	private float moveSpeedIncrementAmount;

	[SerializeField]
	[Tooltip("How quickly the player slides (float).")]
	private float slideSpeed;

	[SerializeField]
	[Tooltip("How high the player jumps (float).")]
	private float jumpHeight;

	[Header("Coroutines")]
	[SerializeField]
	[Tooltip("The delay in seconds before the increase run speed timer goes off (float).")]
	private float moveSpeedIncreaseTimerDelay;
	#endregion

	#region Methods
	protected override void UpdateHealth(int amount)
	{
		health += amount;

		if(health <= 0f)
		{
			// TODO player death logic
			Debug.Log(this.gameObject.name + " is DEAD");
		}

		// prevent the player from gaining more than their max health value
		if(health >= maxHealth)
		{
			health = maxHealth;
		}
	}

	protected override void Attack()
	{
		// TODO attacking logic
		Debug.Log(this.gameObject.name + " ATTACKS");
	}

	private void Move()
	{
		// TODO player movement logic
	}

	private void Jump()
	{
		// TODO player jumping logic
	}

	private void Slide()
	{
		// TODO player sliding logic
	}

	private void IncreaseSpeed()
	{
		// TODO increase player run speed up to a maximum value
	}
	#endregion

	#region MonoBehaviour
	protected override void Awake()
	{
		base.Awake();
	}

	protected override void Update()
	{
		// TODO player update logic
	}

	protected override void OnTriggerEnter2D(Collider2D col)
	{
		// TODO player trigger collision logic
	}
	#endregion

	#region Coroutines
	private IEnumerator NextSpeedIncrease(float delay)
	{
		// TODO player speed increase on timer
		yield return new WaitForSeconds(delay);
	}
	#endregion
}
