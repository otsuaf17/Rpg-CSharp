namespace RPG
{
    public class Players
    {
        PlayerClass playerClass;
        int level;
        int maxHP;
        int hp;
        int defence;
        int strength;
        int dexterity;
        int constituition;
        int intelligence;
        int charisma;
        int xp;

        public int Lv{
            get{ return level; }
            set { level = value; }
        }

        public PlayerClass PlayerClass{
            get { return playerClass; }
            set { playerClass = value; }
        }
        public int MaxHP{
            get { return maxHP; }
            set { maxHP = value; }
        }
        public int Hp{
            get { return hp; }
            set { hp = value; }
        }
        public int Str{
            get { return strength; }
            set { strength = value; }
        }
        public int Dex{
            get { return dexterity; }
            set { dexterity = value; }
        }
        public int Def{
            get { return defence; }
            set { defence = value; }
        }
        public int Con{
            get { return constituition; }
            set { constituition = value; } 
        }
        public int Int{
            get { return intelligence; }
            set { intelligence = value; }
        }
        public int Cha{
            get { return charisma; }
            set {  charisma = value; }
        }
        public int Xp
        {
            get{return xp;}
            set{xp = value;}
        }
    }
}