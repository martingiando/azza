using UnityEngine;

public class test : MonoBehaviour
{
// Start is called before the first frame update. Se llama cuando inicio el juego, una sola vez.

public int vida;
public float velocidad;

public Vector3 escala = new Vector3 (2, 1, 1);

public Vector3 posicion;

public Vector3 direccion;

void Start()
{
    

    vida = 100; // Asignacion de variable. Para probar mostrarlo en la consola.
    Debug.Log(vida);

    velocidad = 0.05f; // Asignacion de velocidad.
    Debug.Log(velocidad);

    direccion = new Vector3 (0 * velocidad, 0 * velocidad, 0.1f * velocidad);

   transform.localScale += escala; // con esto cambio la escala al darle play.
   
}

// Update is called once per frame. Se llama una vez por cada frama; mientras mas FPS más veces se llama.
void Update()
{

       transform.Translate(direccion); // con esto lo muevo en el eje z 0.1 unidades.
       Debug.Log(transform.position);

       transform.Rotate(0, 0.1f, 0); // con esto giro al personaje.

       Debug.DrawRay(transform.position, new Vector3 (1, 0, 0)*5, Color.red); // con esto dibujo una linea en la consola. Podria utilizarlo para dibujar el rango de ataque de un enemigo.

}

void PlayerMove () // con esto creo una funcion para mover al personaje.
{
    transform.Translate(direccion);
}


void Damage (){ // con esto creo una funcion para quitarle vida al personaje.
       vida--;
}

void Healty (){ // con esto creo una funcion para sumarle vida al personaje.
       vida++;
}

}


