using UnityEngine;
using System.Collections;

public class FollowMe : MonoBehaviour {

	//public AlienShot aShot;
	public GameObject goBody;
	Transform target; //el Objetivo 
	public int moveSpeed = 3; //velocidad de movimiento 
	public int rotationSpeed = 3; //Velocidad de rotación 
	public ParticleSystem dust;
	private Animator anim;
	private Transform myTransform;  
	//private float velocidadDeAnimacion;//Solo si tu objeto esta animado 
	private bool boolDead = false;
	private bool boolShot = false;
	public bool boolOnPlayerRadius = false;
	//private bool boolCanShot = true;

	private float fLives;
	void Awake() 
	{ 
		myTransform = transform;  
	} 

	// Use this for initialization
	void Start () 
	{
		//fLives = GameController.fLivesAlien;
		//velocidadDeAnimacion = moveSpeed * 0.3f;
		//anim = GetComponent<Animator>();
		target = GameObject.FindWithTag("Player").transform; //target the player 
	}

	// Update is called once per frame
	void Update () 
	{
		//Controlar la animacion en funcion de la velocidad a la que se mueva, si no esta animado tu objeto puedes dejar comentadas estas 3 lineas.
		/*for (var state : AnimationState in animation) {     
          state.speed = velocidadDeAnimacion; 
    }*/ 
		if (!boolDead && !boolShot && !boolOnPlayerRadius){
			//Rotacion para mirar hacia el target(objetivo a seguir) 
			myTransform.rotation = Quaternion.Slerp(myTransform.rotation, 
				Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);

			//Movimiento en dirección del target 
			myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;}


	}

	void OnTriggerEnter(Collider other) {

		/*if (other.gameObject.tag == "Laser" && !boolDead && fLives <= 0)
		{
			boolDead = true;
			anim.Play("dead");
			StartCoroutine(Dead());
		}else if (other.gameObject.tag == "Laser" && !boolDead)
		{
			//fLives -= GameController.fLaserHit;
		}
*/
	}

	void OnTriggerStay(Collider other) 
	{

		/*if (other.gameObject.tag == "PlayerRadius" && boolCanShot && !boolDead)
		{
			anim.Play("shot");
			boolShot = true;
			boolCanShot = false;
			StartCoroutine(Shot());


		}*/

	}

	void OnTriggerExit(Collider other) {

		/*if (other.gameObject.tag == "PlayerRadius" && !boolDead)
		{
			anim.Play("idle");
			boolShot = false;
		}*/

	}

	/*IEnumerator Dead() 
	{
		/*yield return new WaitForSeconds(3f);
		dust.enableEmission = true;
		GameController.intAliens -= 1;
		GameController.intCredits += GameController.intDestroyAlienCredit;
		yield return new WaitForSeconds(0.5f);
		goBody.SetActive(false);
		yield return new WaitForSeconds(1);
		Destroy(gameObject);* /
	}*/

	/*IEnumerator Shot() 
	{
		/*if (!boolDead){
			aShot.shot(this.transform);
			yield return new WaitForSeconds(1);
			boolCanShot = true;
		}

	}*/
}