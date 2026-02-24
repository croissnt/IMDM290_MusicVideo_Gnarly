using UnityEngine;

public class sphereReact : MonoBehaviour
{
    
    public float scaleSphere = 50f;
    public float moveSphere = 5f;
    float move;
    float scale;
    
    public float angleOffset;
    public float radius = 50f;
    public float rotationSpeed = 1f;
    float angle;
    //Vector3 centerPos;
    //public float rotateSphere = 5f;
    //public float morphSphere = 10f;
    Vector3 moveRandomDirection;
    float time;
    



    void Start()
    {
        
        moveRandomDirection = Random.onUnitSphere;
        //centerPos = transform.position;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //The bottom-left of the camera is (0,0); the top-right is (1,1).
        //https://docs.unity3d.com/6000.3/Documentation/ScriptReference/Camera.WorldToViewportPoint.html
        //Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);

        //Debug.Log(Time.time); //sphere does different actions depending on time!!!
        time = Time.time;
        

        //"You could describe everything with one single word. You know? Like."
        if(time <= 5) //if time is less or equal than 5 seconds
        { 
            controlAmp();
            transform.localScale = Vector3.one * scale;
        }
        //"boba tea", "Tesla", "Fried Chicken", "Partyin' in the Hollywood Hills", "This song", "Oh my God that new beat"
        else if (time >= 5 && time < 6 || time >= 7 && time <8 || time >= 9 && time < 10 
        || time >= 11 && time < 13 || time >= 13 && time < 14 || time >= 14 && time < 16)
        {
            
            //move spheres in circle
            controlMel();
            //transform.position += moveRandomDirection * move * Time.deltaTime; //for moving in random direction
            angle += rotationSpeed * move * Time.deltaTime;

            float currentAngle = angle + angleOffset;

            float x = Mathf.Cos(currentAngle) * radius;
            float y = Mathf.Sin(currentAngle) * radius;

            transform.position = new Vector3(x, y, 0f);

            controlAmp();
            transform.localScale = Vector3.one * scale;

            Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);

           /* if(viewPos.x > 1 || viewPos.x < 0)
            {
                moveRandomDirection.x *= -1;
            }else if
            (viewPos.y > 1 || viewPos.y < 0)
            {
                moveRandomDirection.y *= -1;
            } */

          // first 6 "Gnarly's"
        }else if (time >= 6 && time < 7 || time >= 8 && time < 9 || time >=10 && time < 11 || time >= 14 && time < 15 || time >= 16 && time < 17 || time >= 18 && time < 20)
        {            
            controlAmp();
            transform.localScale = Vector3.one * scale;
            
        }
        // "Oh God is this real?"
        else if(time >= 17 && time <= 19)
        {
            
            controlMel();
            transform.position += moveRandomDirection * move * Time.deltaTime;
            controlAmp();
            transform.localScale = Vector3.one * scale;
        }


        //2nd set of lyrics:
        //"oh we're in a session tonight", "Oh, we're going out tonight", "Oh, my God, this song's so lit, congratulations"
        if(time >= 20 && time < 21 || time >= 22 && time < 23 || time >= 24 && time < 27){
            controlAmp();
            transform.localScale = Vector3.one * scale;
            
            rotationSpeed = 0.3f;
            angle += rotationSpeed * move * Time.deltaTime;

            float currentAngle = angle + angleOffset;

            float x = Mathf.Cos(currentAngle) * radius;
            float y = Mathf.Sin(currentAngle) * radius;

            transform.position = new Vector3(x, y, 0f);

            
        }
        //4 sets of "gangs"
        else if(time >= 21 && time < 22 || time >= 23 && time < 24 || time >=28 && time < 30)
        {
            controlAmp();
            transform.localScale = Vector3.one * scale;
        }


        //3rd set of lyrics:
        //"gnarly"
        if(time >=30 && time <=31 || time >=34 && time <35 || time >= 37 && time < 38 || time >= 40 && time < 41 || time >= 42 && time < 43)
        {
            controlAmp();
             rotationSpeed = 1f;
            transform.localScale = Vector3.one * scale;
            angle += rotationSpeed * move * Time.deltaTime;

            float currentAngle = angle + angleOffset;

            float x = Mathf.Cos(currentAngle) * radius;
            float y = Mathf.Sin(currentAngle) * radius;

            transform.position = new Vector3(x, y, 0f);

            
        }
        //"na-na-na na-na-na"
        else if (time >=31 && time < 34 || time >= 35 && time < 37 || time >= 38 && time < 40 || time >= 40 && time < 42)
        {
            controlAmp();
            transform.position += moveRandomDirection * move * Time.deltaTime;
            transform.localScale = Vector3.one * scale;
        }
        //"everything's gnarly
        else if(time >= 43 && time < 44)
        {
            controlMel();
            transform.localScale = Vector3.one * scale;
        }

        
        //4th set of lyrics

        //"Hottie hottie", "Obvi' obvi'"
        if(time >= 45 && time < 46 || time >= 52 && time < 54)
        {
            rotationSpeed = 2f;
            controlAmp();
            transform.localScale = Vector3.one * scale;
             angle += rotationSpeed * move * Time.deltaTime;

            float currentAngle = angle + angleOffset;

            float x = Mathf.Cos(currentAngle) * radius;
            float y = Mathf.Sin(currentAngle) * radius;

            transform.position = new Vector3(x, y, 0f);   
        }
        //"like a bag of takis", "They be tryna copy"
        else if(time >= 46 && time < 48 || time >=54 && time < 55)
        {
            controlAmp();
            transform.localScale = Vector3.one * scale;
            controlMel();
            transform.position += moveRandomDirection * move * Time.deltaTime;
        }
        //"I'm the sh*t", "I'm the sh*t"
        else if(time >= 48 && time < 51 || time >= 55 && time < 57)
        {
            controlAmp();
             transform.localScale = Vector3.one * scale;
        }
        //beat noises after "I'm the sh*t"
        else if(time >= 51 && time < 52 || time >= 57 && time < 59)
        {
            controlAmp();
            transform.localScale = Vector3.one * scale;
        }


        //5th set of lyrics:

        // "na-na-na x1 then gnarly"
        if(time>= 59 && time < 62 || time >= 66 && time < 69)
        {
            controlAmp();
            rotationSpeed = 0.7f;
            transform.localScale = Vector3.one * scale;
            angle += rotationSpeed * move * Time.deltaTime;

            float currentAngle = angle + angleOffset;

            float x = Mathf.Cos(currentAngle) * radius;
            float y = Mathf.Sin(currentAngle) * radius;

            transform.position = new Vector3(x, y, 0f);

        }

        //"im the sh*t" x 2
        if(time >= 62 && time < 66 || time >= 69 && time < 73)
        {
            controlAmp();
            transform.localScale = Vector3.one * scale;

        }
        
        

    }

        //music video ideas:
        /*
        - at "gang gang gang ..." have spheres move in different random directions for each "gang" while scaling in size 
        - at each "GNARLY", after saying the foods, spheres pulse 
        - want hues of spheres to continuously change from 60-150 in hue cycle (shades of green)
        - at the "I'm the sh*t" use amp and after the small pause, have them move once in random directions
        - at the "na na na na gnarly" use mel have them pulse and move

        */
    

    
    void controlAmp()
    {
        scaleSphere = 2f;
        float amp = AudioSpectrum.audioAmp; //getting amplitude from song

        //How to manipulate sphere according to amplitude:
        //scale sphere:
        scale = amp * scaleSphere; //multiplying amp with scaleSphere to show on camera
        //transform.localScale = Vector3.one * scale; //all x, y, and z values are scaled by same num

        //move sphere:
        move = amp * moveSphere;

         //rotate sphere:
        //float rotate = amp * rotateSphere;
        //transform.Rotate(0f, rotate * Time.deltaTime, 0f); example

        //stretch or shrink sphere: will work on later. want to try mesh
        //float morph = amp * morphSphere;
    }

    void controlMel()
    {
        float mel = AudioSpectrum.brass; //getting melody from song
       
        scale = 1f + mel * scaleSphere;

         //transform.position = new Vector3(move, move, move); example
        move = 1f + mel * moveSphere;

    }

    void controlBass()
    {
        float bass = AudioSpectrum.percussion; //getting brass(bass?) from song

        scale = 1f + bass * scaleSphere;

        move = bass * moveSphere;
    }
}

