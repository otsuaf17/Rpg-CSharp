namespace RPG
{
    public class Selection
    {
        public static void PlayerSelect()
        {
            Console.WriteLine("Rpg da massa");
            Console.WriteLine("Selecione seu personagem");
            Console.WriteLine("1-Guerreiro");
            Console.WriteLine("2-Mago");
            Console.WriteLine("3-Arqueiro");
            Console.WriteLine("4-Ladino");
            Console.Write("Sua Escolha sera: ");
            int opc = int.Parse(Console.ReadLine()??"");
            
            var player = new Players();

            switch(opc)
            {
                //Guerreiro
                case 1:
                player.PlayerClass = PlayerClass.WARRIOR;
                player.MaxHP = 300;
                player.Hp = player.MaxHP;
                player.Def = 100;
                break;
                    
                //Mago
                case 2:
                player.PlayerClass = PlayerClass.MAGE;
                player.MaxHP = 90;
                player.Hp = player.MaxHP;
                player.Def = 100;
                break;
                    
                //Arqueiro 
                case 3:
                player.PlayerClass = PlayerClass.ARCHER;
                player.MaxHP = 115;
                player.Hp = player.MaxHP;
                player.Def = 50;
                break;
                
                //Ladino
                case 4:
                player.PlayerClass = PlayerClass.ROGUE;
                player.MaxHP = 125;
                player.Hp = player.MaxHP;
                player.Def = 35;
                break;
            }

            player.Lv = 1;
            player.Dex = ValueAttributes();
            player.Str = ValueAttributes();
            player.Con = ValueAttributes();
            player.Int = ValueAttributes();
            player.Cha = ValueAttributes();
            player.Xp = 0;

            Console.WriteLine($"Classe: {player.PlayerClass}");
            Console.WriteLine($"Maximo de HP: {player.MaxHP}");
            Console.WriteLine($"HP: {player.Hp}");
            Console.WriteLine($"Def: {player.Def}");
            Console.WriteLine($"Lv: {player.Lv}");
            Console.WriteLine($"Dex: {player.Dex}");
            Console.WriteLine($"Str: {player.Str}");
            Console.WriteLine($"Con: {player.Con}");
            Console.WriteLine($"Int: {player.Int}");
            Console.WriteLine($"Cha: {player.Cha}");
            Console.WriteLine($"Xp: {player.Xp}");
        }
        private static int ValueAttributes()
        {
            int[] diceValue = new int[4];
            int totalValue = 0;
            Random Dice = new();
            for(int i = 0; i<4; i++)
            {
                diceValue[i] = Dice.Next(1,7);
                totalValue += diceValue[i];
            }
            return totalValue - diceValue.Min();
        }
    }
}