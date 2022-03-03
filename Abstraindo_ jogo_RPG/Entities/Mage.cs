namespace Abstraindo__jogo_RPG.Entities
{
    public class Mage : Hero //Mage irá herdar tudo de hero
    {

        public Mage (string Name, int Lvl, string HeroType, int Hp, int Mp)
        {
            this.Name = Name; //usa-se o comando this para dizer que é o Name dos parâmetros ali em baixo
            this.Lvl = Lvl;
            this.HeroType = HeroType;
            this.Hp = Hp;
            this.Mp = Mp;
        }
        public virtual string Attack(){
            return this.Name + " lançou magia"
        }
    }
}