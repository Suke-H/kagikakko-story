using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVPR.Model
{
    public class GoalModel : MonoBehaviour
    {
        private ObjectType goalCondition;

        public void Initialize(ObjectType goalCondition)
        {
            this.goalCondition = goalCondition;
        }
    }
}

