using Pada1.BBCore;
using UnityEngine;
namespace BBUnity.Conditions
{
	
	[Condition("Perception/HasBullets")]
	[Help("Checks if the enemy still has Bullets")]

	public class HasBullets : GOCondition
	{
		
		
        public override bool Check()
        {
			int a = GameObject.FindWithTag("tagEnemy").GetComponent<numberBullets>().bullets;
			return !(a>=0);
        }
    }
}

