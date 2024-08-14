using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests;

public class BasketTest
{
  

    [Test] 
    public void testOrderBagel()
    {
        //SetUp
        Basket basket = new Basket();
        string bagel = "bagel";

        //Execute
        basket.orderBagel("bagel");

        //Verify
        Assert.That(basket.Items.Contains(bagel));
    }

    [Test]
    public void testRemoveBagel()
    {
        //SetUp
        Basket basket = new Basket();
        int expected = basket.capasity;

        //Execute
        basket.removeBagel();
        int result = basket.capasity;

        //Verify
        Assert.That(result == expected -1);
        

    }

    [Test]
    public void testIsFull()
    {
        //SetUp
        Basket basket = new Basket();
        basket.capasity = 0;

        //Execute
        

        //Verify
        Assert.IsTrue(basket.isFull());
    }

    [Test]
    public void testNotFull()
    {
        //SetUp
        Basket basket = new Basket();


        //Execute
        basket.capasity = 10;

        //Verify
        Assert.IsFalse(basket.isFull());
    }

    [Test]
    public void testChangeCapacity()
    {
        //SetUp
        Basket basket = new Basket();
        

        //Execute
        int result = basket.changeCapacity(6);

        //Verify
        Assert.That(basket.capasity == result);
    }


    [Test]
    public void testDoesExist()
    {
        //SetUp
        Basket basket = new Basket();


        //Execute
        bool result = basket.doesExist("cheese-bagel");

        //Verify
        Assert.IsTrue(result);

    }   
    
    [Test]
    public void testDoesNotExist()
    {
        //SetUp
        Basket basket = new Basket();


        //Execute
        bool result = basket.doesExist("cheese-bagel");

        //Verify
        Assert.IsFalse(result);
    }
}