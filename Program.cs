using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using Microsoft.ML.Transforms;
using static Microsoft.ML.DataOperationsCatalog;

//using Microsoft.ML.DataOperationCatalog();
namespace Project_1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
       // [STAThread]

        //1) declaring path for to saving trained model of Machine Learning
        static readonly string _modelPath = Path.Combine(Environment.CurrentDirectory, "Model.zip");

        static void Main()
        {
            // menu obj = new menu();
            // obj.get_symp();
            // string selectedValue = obj.get_symp();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //ML Implementation

        }
    }
}
