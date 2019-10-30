using UnityEngine;

public abstract class AbstractActor : MonoBehaviour
{
	#region Serialize Fields
	[Header("Health and Combat Stats")]
	[SerializeField]
	[Tooltip("The maximum amount of health that the actor has (float).")]
	protected float maxHealth;

	[SerializeField]
	[Tooltip("The amount of damage the actor deals when attacking (float).")]
	protected float attackDamage;
	#endregion

	#region Variables
	protected float health;
	#endregion

	#region Methods
	/// <summary>
	/// Updates the actor's health value by the passed amount.
	/// </summary>
	/// <param name="amount">The amount to change the health value by. Positive will increase health, negative will decrease health.</param>
	protected abstract void UpdateHealth(int amount);

	protected abstract void Attack();
	#endregion

	#region MonoBehaviour
	protected virtual void Awake()
	{
		// set the actor's health value equal to the actor's maxHealth value.
		health = maxHealth;
	}

	protected abstract void Update();

	protected abstract void OnTriggerEnter2D(Collider2D col);
	#endregion
}
