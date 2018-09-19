using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animation))]
public class ShootableBox : MonoBehaviour {

	//The box's current health point total
	public int currentHealth = 3;
	public string Color;

	[Header("Numerp de animaciones")]
	public int Rojo;
	public int Azul;
	public int Verde;
	
	[Header("Referencias")]
	[SerializeField]
	private Animation anim;

	public void Damage(string s)
	{
		if(!anim.isPlaying){
			if (s == "Rojo")
			{
				int n = Random.Range(1, Rojo + 1);
				anim.Play("Rojo" + n.ToString());
			}
			else if (s == "Azul")
			{
				int n = Random.Range(1, Azul + 1);
				anim.Play("Azul" + n.ToString());
			}
			else if (s == "Verde")
			{
				int n = Random.Range(1, Verde + 1);
				anim.Play("Verde" + n.ToString());
			}
		//Debug.Log("Disparo " + s);
		}
	}
}
