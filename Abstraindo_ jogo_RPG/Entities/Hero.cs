namespace Abstraindo__jogo_RPG.Entities
{
    public class Hero
    {
        public Hero (string Name, int Lvl, string HeroType, int Hp, int Mp)
        {
            this.Name = Name; //usa-se o comando this para dizer que é o Name dos parâmetros ali em baixo
            this.Lvl = Lvl;
            this.HeroType = HeroType;
            this.Hp = Hp;
            this.Mp = Mp;
        }

        public Hero{
            //um exemplo de construtor vazio, tornando nao obrigatorio passar os parametros
        }
        

        public string Name;
        
        public int Lvl;

        public string HeroType;
       
        public int Hp;

        public int Mp;

        public override string ToString(){ //sobrescrita de método
            return this.Name + " " + this.Lvl + " " + this.HeroType;
        }

        public string Attack(){
            return this.Name + "Atacou com a sua espada";
        }
    }
}