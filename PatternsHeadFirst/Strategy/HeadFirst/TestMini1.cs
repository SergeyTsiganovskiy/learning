using System;

namespace PatternsHeadFirst.Strategy
{
    public class TestMini1
    {
        public static void main1(String[] args)
        {

            MallardDuck mallard = new MallardDuck();
            RubberDuck rubberDuckie = new RubberDuck();
            DecoyDuck decoy = new DecoyDuck();
            ModelDuck model = new ModelDuck();

            mallard.PerformQuack();
            rubberDuckie.PerformQuack();
            decoy.PerformQuack();

            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();
        }
    }
}
