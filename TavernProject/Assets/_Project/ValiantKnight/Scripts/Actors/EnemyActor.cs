using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyActor : AbstractActor
{
	#region Methods
	protected override void UpdateHealth(int amount)
	{
		health += amount;

		if (health <= 0f)
		{
			// TODO enemy death logic
			Debug.Log(this.gameObject.name + " is DEAD");
		}

		// prevent the enemy from gaining more than their max health value
		if (health >= maxHealth)
		{
			health = maxHealth;
		}
	}

	protected override void Attack()
	{
		// TODO attacking logic
		Debug.Log(this.gameObject.name + " ATTACKS");
	}
	#endregion

	#region MonoBehaviour
	protected override void Awake()
	{
		base.Awake();
	}

	protected override void Update()
	{
		// TODO enemy update logic
	}

	protected override void OnTriggerEnter2D(Collider2D col)
	{
		// TODO enemy trigger collision logic
	}
	#endregion
}
