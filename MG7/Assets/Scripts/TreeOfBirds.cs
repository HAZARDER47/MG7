using UnityEngine;

public class TreeOfBirds : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private GameObject[] _sparrows;
    [SerializeField, Min(0f)] private float _interactionDistance = 3f;

    private void Update()
    {
        foreach (GameObject sparrow in _sparrows)
        {
            if (sparrow == null || sparrow.activeSelf)
                continue;

            float distance = Vector3.Distance(
                _player.position, sparrow.transform.position);

            if (distance <= _interactionDistance)
                sparrow.SetActive(true);
        }
    }
}