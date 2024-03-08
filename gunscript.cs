
using UnityEngine;

public class gunscript : MonoBehaviour
{
   [SerializeField]
  private GameObject bullet;
    [SerializeField]
  private Transform muzzle;
   [SerializeField]
   private Joystick joystick;
    [SerializeField]
   private Transform shotpoint;
   private float Timebtwshots;
   [SerializeField]
   private float stTimebtwshots;
 
  
    void Update()
    {
        if(Timebtwshots<=0){
       if(joystick.Horizontal>0.8||joystick.Vertical>0.7||joystick.Horizontal<-0.8||joystick.Vertical<-0.8)
       { 
        FindObjectOfType<AudioManager>().Play("gunshot");
        {Instantiate( bullet , shotpoint.position, transform.rotation);}
        Transform clone= Instantiate( muzzle , shotpoint.position, transform.rotation) as Transform;
        clone.parent=shotpoint;
        Destroy(clone.gameObject, 0.1f);
        Timebtwshots=stTimebtwshots;
    } }
else{
    Timebtwshots-=Time.deltaTime;
}

}//update

}
