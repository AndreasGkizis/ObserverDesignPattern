using Xunit.Abstractions;

namespace UnitTests
{
    /// <summary>
    /// Automatic Testing with xUnit
    /// </summary>
    public class UnitTests 
        : IDisposable
    {
        /// <summary>
        /// There is a Setup and TearDown phase for every test
        /// This is needed to ensure the tests are not dependent on the order the are executed
        /// , in xUnit the Setup phase is whatever is in the constructor  and the TearDown is the Dispose method
        /// </summary>

        // This allows to output to the test runner, more readability of the results of the tests
        private ITestOutputHelper _output;

        // Construtor = Setup
        // Make tent before sleeping 
        public UnitTests(ITestOutputHelper output)
        {
            // we inject ITestOutputHelper so that each test can use the output for a custom message
            this._output = output;
        }

        // Dispose = TearDown 
        // Disassemble tent before leaving 
        public void Dispose() { 
        
        }

        /// <summary>
        /// Triple A rule. 
        /// Each test must have 3 things , Arrange, Act, Assert
        /// Arrange = Gather and organise the things you might need to run each test. Several Arranges can happen without any issue
        /// ( data, enviroment , classes.. pretty much anything you are going to need) 
        /// Act = THERE CAN ONLY BE ONE PER TEST , you actually call use use the test subject  
        /// Assert =  There can be multiple, here you check if the result is the expect 
        /// </summary>

        // [Fact] = this must happen 
        // [Fact(Skip = "Some Excuse to skip the test"] = this will skipp the test while auto-testing  DO NOT DO THIS 
        // [Fact(DisplayName ="name the test for readability ")]
        [Fact]
        public void FirstFact()
        {
            _output.WriteLine("my first output message ");
            Assert.Equal(5, 3 + 2);
        }
        // [Theory] =  tests multiple scenarios one might fail many can pass 
        // [InlineData()] =  Here you provide data for each test, Can have as many as you like(?)

        [Theory]
        [InlineData()]
        [InlineData()]
        [InlineData()]
        [InlineData()]
        [InlineData()]
        [InlineData()]
        [InlineData()]
        [InlineData()]
        public void FirstTheory()
        {

        } 


    }
}