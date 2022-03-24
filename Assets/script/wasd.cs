using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wasd : MonoBehaviour
{
    public Vector3 scaleChange;
	Vector3 m;
	float x, y, z;
	// Start is called before the first frame update
	void Start()
	{
		
		m.x = 0.0f;
		m.y = 0.0f;
		m.z = 0.0f;
	}

	// Update is called once per frame
	void Update()

	{

		if (Input.GetKey(KeyCode.D))
		{
			m.x = 0.02f;
			Movimento(m);
			LogMessage("d");
			m.x = 0.0f;
		}
		if (Input.GetKey(KeyCode.A))
		{

			m.x = -0.02f;
			Movimento(m);
			LogMessage("a");
			m.x = 0.0f;

		}
		if (Input.GetKey(KeyCode.S))
		{
			m.z = -0.02f;
			Movimento(m);
			LogMessage("s");
			m.z = 0.0f;
		}
		if (Input.GetKey(KeyCode.W))
		{
			m.z = 0.02f;
			Movimento(m);
			LogMessage("w");
		}
		if (Input.GetKey(KeyCode.X))
		{
			x = Random.Range(1.0f, 100.0f);
			y = Random.Range(1.0f, 100.0f);
			z = Random.Range(1.0f, 100.0f);
			scaleChange.Set(x, y, z);
			Escala(scaleChange);
		}
		if (Input.GetKey(KeyCode.R))
		{
			x = Random.Range(1.0f, 100.0f);
			y = Random.Range(1.0f, 100.0f);
			z = Random.Range(1.0f, 100.0f);
			scaleChange.Set(x, y, z);
			Rotacao(scaleChange);
		}






	}

	void Escala(Vector3 x)
	{
		transform.localScale = x;
	}
	void Rotacao(Vector3 x)
	{
		transform.Rotate(x);
	}

	void Movimento(Vector3 m)
	{
		transform.Translate(m);

	}

	void LogMessage(string msg)
	{

		Debug.Log("A opção selecionada foi " + msg.ToUpper());
	}
}
