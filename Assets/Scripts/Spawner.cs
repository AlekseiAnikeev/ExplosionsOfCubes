using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Cube _cube;
    [SerializeField] private CubeCreate _createObject;

    private int _minRandomCount = 2;
    private int _maxRandomCount = 6;

    private void OnEnable()
    {
        _cube.Clicked += Cliked;
    }

    private void OnDisable()
    {
        _cube.Clicked -= Cliked;
    }

    private void Cliked()
    {
        int randomCount = Random.Range(_minRandomCount, _maxRandomCount);

        if (_cube.CanSplit())
        {
            for (int i = 0; i < randomCount; i++)
                _createObject.Create(_cube.transform.position);

            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}