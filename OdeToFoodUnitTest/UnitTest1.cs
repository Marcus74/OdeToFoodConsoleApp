using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OdeToFoodConsoleApp.Data;
using OdeToFoodConsoleApp.DAL;
using OdeToFoodConsoleApp.DI;
using OdeToFoodConsoleApp.staticMethods;
using OdeToFoodConsoleApp.View;

namespace OdeToFoodUnitTest
{
    [TestClass]
    public class UnitTest1
    {

        #region TimeOfDay
        [TestMethod]
        public void ValidateTimeOfDayMorningTestMethod()
        {
            var isMorning = "morning".IsMorningCheck();
            Assert.AreNotEqual(isMorning, null);
        }

        [TestMethod]
        public void ValidateTimeOfDayNightTestMethod()
        {
            var isMorning = "night".IsMorningCheck();
            Assert.AreNotEqual(isMorning, null);
        }

        [TestMethod]
        public void ValidateTimeOfDayBadTestMethod()
        {
            var isMorning = "abcdefg".IsMorningCheck();
            Assert.AreEqual(isMorning, null);
        }
        #endregion

        [TestMethod]
        public void ValidateGetFoodListTestMethod()
        {
            var listOfFood = Dishes.GetFoodList2();

            foreach (var item in listOfFood)
            {
                Debug.WriteLine(item.Value.Count);
                Debug.WriteLine(item.Value.MorningDish);
                Debug.WriteLine(item.Value.NightDish);
            }

            Assert.AreNotEqual(listOfFood.Count, 0);
        }

        #region Samples
        [TestMethod]
        public void Sample1TestMethod()
        {
            Writer.SetWriter<DebugOutput>();

            const string request = "morning, 1, 2, 3";
            var req = request.Replace(" ", "")
                            .Split(',');

            string output;
            using (var order = new OrderUp())
            {
                var response = order.GetOrder(req);
               output = Parser.ParseOrders(response);

                Writer.WriteOutput(output);
            }

            Assert.AreEqual("Output: eggs, toast, coffee", output);
        }

        [TestMethod]
        public void Sample2TestMethod()
        {
            Writer.SetWriter<DebugOutput>();

            const string request = "morning, 2, 1, 3";
            var req = request.Replace(" ", "")
                            .Split(',');

            string output;
            using (var order = new OrderUp())
            {
                var response = order.GetOrder(req);
                output = Parser.ParseOrders(response);

                Writer.WriteOutput(output);
            }

            Assert.AreEqual("Output: eggs, toast, coffee", output);
        }

        [TestMethod]
        public void Sample3TestMethod()
        {
            Writer.SetWriter<DebugOutput>();

            const string request = "morning, 1, 2, 3, 4";
            var req = request.Replace(" ", "")
                            .Split(',');

            string output;
            using (var order = new OrderUp())
            {
                var response = order.GetOrder(req);
                output = Parser.ParseOrders(response);

                Writer.WriteOutput(output);
            }

            Assert.AreEqual("Output: eggs, toast, coffee, error", output);
        }

        [TestMethod]
        public void Sample4TestMethod()
        {
            Writer.SetWriter<DebugOutput>();

            const string request = "morning, 1, 2, 3, 3, 3";
            var req = request.Replace(" ", "")
                            .Split(',');

            string output;
            using (var order = new OrderUp())
            {
                var response = order.GetOrder(req);
                output = Parser.ParseOrders(response);

                Writer.WriteOutput(output);
            }

            Assert.AreEqual("Output: eggs, toast, coffee(x3)", output);
        }

        [TestMethod]
        public void Sample5TestMethod()
        {
            Writer.SetWriter<DebugOutput>();

            const string request = "night, 1, 2, 3, 4";
            var req = request.Replace(" ", "")
                            .Split(',');

            string output;
            using (var order = new OrderUp())
            {
                var response = order.GetOrder(req);
                output = Parser.ParseOrders(response);

                Writer.WriteOutput(output);
            }

            Assert.AreEqual("Output: steak, potato, wine, cake", output);
        }

        [TestMethod]
        public void Sample6TestMethod()
        {
            Writer.SetWriter<DebugOutput>();

            const string request = "night, 1, 2, 2, 4";
            var req = request.Replace(" ", "")
                            .Split(',');

            string output;
            using (var order = new OrderUp())
            {
                var response = order.GetOrder(req);
                output = Parser.ParseOrders(response);

                Writer.WriteOutput(output);
            }

            Assert.AreEqual("Output: steak, potato(x2), cake", output);
        }

        [TestMethod]
        public void Sample7TestMethod()
        {
            Writer.SetWriter<DebugOutput>();

            const string request = "night, 1, 2, 3, 5";
            var req = request.Replace(" ", "")
                            .Split(',');

            string output;
            using (var order = new OrderUp())
            {
                var response = order.GetOrder(req);
                output = Parser.ParseOrders(response);

                Writer.WriteOutput(output);
            }

            Assert.AreEqual("Output: steak, potato, wine, error", output);
        }

        [TestMethod]
        public void Sample8TestMethod()
        {
            Writer.SetWriter<DebugOutput>();

            const string request = "night, 1, 1, 2, 3, 5";
            var req = request.Replace(" ", "")
                            .Split(',');

            string output;
            using (var order = new OrderUp())
            {
                var response = order.GetOrder(req);
                output = Parser.ParseOrders(response);

                Writer.WriteOutput(output);
            }

            Assert.AreEqual("Output: steak, error", output);
        }
        #endregion
    }
}
