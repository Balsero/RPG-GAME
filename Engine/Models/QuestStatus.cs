using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class QuestStatus
    {
        public Quest PlayerQuest { get; }
        public bool IsCompleted { get; set; }

        public QuestStatus(Quest playerQuest)
        {
            PlayerQuest = playerQuest;
            IsCompleted = false;
        }
    }
}
