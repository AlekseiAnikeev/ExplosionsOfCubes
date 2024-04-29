using UnityEngine;

public class CubeCreate : MonoBehaviour
{
    [SerializeField] private Cube _cube;

    private float _sizeSeparation = 2f;

    public Cube Create(Vector3 position)
    {
        Cube cube = Instantiate(_cube, position, Quaternion.identity);
        cube.transform.localScale /= _sizeSeparation;
        cube.SetChance(_cube.CurrentChance);
        cube.SetColor(CreateRandomColor);

        return cube;
    }

    private Color CreateRandomColor => new Color(Random.value, Random.value, Random.value);
}