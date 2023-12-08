using NUnit.Framework;
using MyMath;



namespace Tests{


    [TestFixture]
    public class Test_NumberAddition
    {
        private Operations _myMath;

        [SetUp]
        public void Setup()
        {
            _myMath = new Operations();
        }

        /// <summary>
        /// Test if addition of two numbers is 4
        /// </summary>
        [Test]
        public void AdditionOperation()
        {
            bool state = false;
          if((Operations.Add(2, 2)) == 4){
            state = true;
          }
            Assert.IsTrue(state, "State is True");
            
        }
    }
}