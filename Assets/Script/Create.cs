using UnityEngine;
using System.Collections;

public class Create : MonoBehaviour
{
    public GameObject astart;
    public GameObject barrier;
    public GameObject trap;
    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            float x = Random.Range(-5f, 5f);
            float z = Random.Range(-23f, 23f);
            Instantiate(trap, new Vector3(x, 1, z), Quaternion.identity);
        }
        StartCoroutine(Tr());
    }

    public void CreateBarrier()
    {
        float x = Random.Range(-5f, 5f);
        float z = Random.Range(-23f, 23f);
        Instantiate(barrier, new Vector3(x, 1, z), Quaternion.identity);
        StartCoroutine(P());
    }

    IEnumerator P()
    {
        yield return new WaitForSeconds(0.1f);
        astart.GetComponent<AstarPath>().Scan();
        yield return new WaitForSeconds(0.5f);
        this.GetComponent<Move>().RePath();
    }

    IEnumerator Tr()
    {
        while (true)
        {
            float x = Random.Range(-5f, 5f);
            float z = Random.Range(-23f, 23f);
            Instantiate(trap, new Vector3(x, 1, z), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
