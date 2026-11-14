using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private bool isChasing = false;
    private GameObject cat;

    void Awake()
    {
        cat = GameObject.FindGameObjectWithTag("Cat");
    }

    void Update()
    {
         if (cat == null)
        {
            Debug.LogError("Cat not found!");
            return;
        }

        if (isChasing)
        {
            Debug.Log("Bat is chasing!");
            
            Vector3 direction = (cat.transform.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
        }
    }


    public void StartChasing()
    {
        isChasing = true;
    }

    public void StopChasing()
    {
        isChasing = false;
    }
}