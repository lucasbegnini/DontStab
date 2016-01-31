using UnityEngine;
using System.Collections;

public class CallShadow : MonoBehaviour {

    public GameObject[] sombra;
    private int num;
    private float delay = 1.5f;
    
    public int knivesCount;
    public float attackWait;
    public float startWait;
    public float waveWait;

    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < knivesCount; i++)
            {
                num = (int)Random.Range(0.0f, 4.0f);
                sombra[num].SetActive(true);
                sombra[num].ShakeScale(new Vector3(0.3f, 0.3f, 0.3f), delay, 0f);
                sombra[num].GetComponent<CallKnife>().PrepararAtaque(delay);

                yield return new WaitForSeconds(attackWait);
            }
            yield return new WaitForSeconds(waveWait);

            knivesCount = knivesCount + 5;
            if(delay-1 < 0.5f)
                delay = delay - 0.2f;
        }
    }
}
