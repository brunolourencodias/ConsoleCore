using GameTop.Interface;
namespace GameTop.Lib
{
    public class Jogador3 : iJogador
    {
        public string Chuta()
        {
            return "Bruno estas pateando \n";
        }

        public string Corre()
        {
            return "Bruno estas corriendo \n";
        }

        public string Passe()
        {
            return "Bruno estas passando \n";
        }
    }
}