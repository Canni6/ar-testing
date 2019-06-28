using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGameController : MonoBehaviour
{
    public GameObject TurbinePrefab;
    public float rotationSpeed = 80f;
    public List<GameObject> RotorGroup = new List<GameObject>();

    private void CreateNewTurbine()
    {
        GameObject NewTurbine = Instantiate(TurbinePrefab, new Vector3(0, 0, 0), Quaternion.identity);

        for (int i = 0; i < NewTurbine.transform.childCount; i++)
        {
            Transform currentItem = NewTurbine.transform.GetChild(i);
            // search by name
            if (currentItem.name.Equals("RotorGroup"))
            {
                // try create new public variable below...
                RotorGroup.Add(currentItem.gameObject);
                currentItem.transform.Rotate(0, 0, Time.deltaTime * rotationSpeed);
                continue;

            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // instantiate prefab at runtime
        CreateNewTurbine();
    }

    // Update is called once per frame
    void Update()
    {
        RotorGroup[0].transform.Rotate(0, 0, -1 * Time.deltaTime * rotationSpeed);
    }
}