using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    private float maxHealth = 100;
    [SerializeField]
    private float currentHealth;

    private bool IsAlive => this.currentHealth > 0;

    private void Start()
    {
        this.currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        DestroyOnDeath();
    }

    public float ReduceHealthByAmount(float dmg)
    {
        this.currentHealth -= dmg;
        return this.currentHealth;
    }

    public void SetCurrentHealth(float health) => this.currentHealth = health;

    public void AddHealth(float amount)
    {
        this.currentHealth += amount;

        if (this.currentHealth > this.maxHealth)
        {
            this.currentHealth = maxHealth;
        }
    }

    public void SetInitialValues(float health)
    {
        this.maxHealth = this.currentHealth = health;
    }

    private void DestroyOnDeath()
    {
        if (!this.IsAlive)
        {
            SendMessage("Destroyed");
        }
    }

}
