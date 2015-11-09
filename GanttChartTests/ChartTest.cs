﻿using Braincase.GanttChart;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GanttChartTests
{
    /// <summary>
    ///This is a test class for ChartTest and is intended
    ///to contain all ChartTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ChartTest
    {
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        [TestMethod()]
        public void AddChartToForm()
        {
            // add to form
            Form form = new Form();
            Chart chart = new Chart();
            form.Controls.Add(chart);

            // init chart
            var manager = new ProjectManager<Task, object>();
            chart.Init(manager);
        }

        /// <summary>
        ///A test for Init
        ///</summary>
        [TestMethod()]
        public void DeferredAddChartToForm()
        {
            Chart chart = new Chart();
            var manager = new ProjectManager<Task, object>();
            chart.Init(manager);

            // deferred add to form
            Form form = new Form();
            form.Controls.Add(chart);
        }

        /// <summary>
        /// Allow drawing without init
        /// </summary>
        [TestMethod()]
        public void DrawWithoutInit()
        {
            Chart chart = new Chart();
            Form form = new Form();

            // test: paint chart without initialization
            chart.Invalidate();
        }
    }
}
