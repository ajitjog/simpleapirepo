using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using SimpleApi.Controllers;

namespace SimpleApiTest
{
    public class Tests
    {
       
        [Test]
        public void TestCalcController()
        {

            CalcController cc = new CalcController();

            var res = cc.Get(10, 40) as OkObjectResult ;

            // Assert
            int r = (int)res.Value;
            Assert.AreEqual(50, r);


        }
    }
}