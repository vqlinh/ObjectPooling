using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject spaceshipPrefab;
    public int numberOfSpaceships = 12;
    public float formationRadius = 3f;
    public float rotationSpeed = 30f;

    private void Start()
    {
        CreateSpaceships();
    }

    private void CreateSpaceships()
    {
        float angleIncrement = 360f / numberOfSpaceships;

        for (int i = 0; i < numberOfSpaceships; i++)
        {
            float angle = i * angleIncrement;
            float x = formationRadius * Mathf.Cos(angle * Mathf.Deg2Rad);
            float y = formationRadius * Mathf.Sin(angle * Mathf.Deg2Rad);
            Vector3 spawnPosition = new Vector3(x, y, 0);

            GameObject spaceship = Instantiate(spaceshipPrefab, spawnPosition, Quaternion.identity);
            spaceship.transform.parent = transform;
        }
    }

    private void Update()
    {
        RotateFormation();
    }

    private void RotateFormation()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
