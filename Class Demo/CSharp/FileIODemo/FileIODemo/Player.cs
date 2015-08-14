using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;
namespace FileIODemo
{
    [Serializable]
    public class Player:ISerializable
    {
       public int id;
       public string name;
       public double score;
        public Player(SerializationInfo info, 
            StreamingContext context)
        {
            name = info.GetString("PlayerName");
            id = info.GetInt32("PlayerId");
            score = info.GetDouble("Score");
        }
        public void GetObjectData(SerializationInfo info,
            StreamingContext context)
        {
            info.AddValue("PlayerName", name);
            info.AddValue("PlayerId", id);
            info.AddValue("Score", score);
        }
        public Player()
        {
            this.id = 0;
            name = "";
            score = 0;
        }
        public Player(string nm, int id, double bs)
        {
            this.id = id;
            name = nm;
            score = bs;
        }
        public override string ToString()
        {
            return "\nName=" + name + "\tId=" + id + "\tScore=" + score;
        }
    
       
    }
}
