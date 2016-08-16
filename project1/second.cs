/*
 * Created by Ranorex
 * User: Damodar Shanbhag
 * Date: 27-07-2016
 * Time: 10.48 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;
using System.IO;
	using System.Diagnostics;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace project1
{
    /// <summary>
    /// Description of second_edit.
    /// </summary>
    [TestModule("CD20FCA7-B585-4C71-A6F0-2E74CBB506F8", ModuleType.UserCode, 1)]
    public class Second : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        //public static project1Repository repo = project1Repository.Instance;
        public Second()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            string path = @"C:\Users\Damodar Shanbhag\Downloads\inb-Callflow.xml";
         string text = File.ReadAllText(path,Encoding.UTF8);
        // text = text.Replace("487777777","666667777");
         // File.WriteAllText(path, text,Encoding.UTF8);
         
       string path1 = @"C:\Users\Damodar Shanbhag\Downloads\inb-Callflow(1).xml";
         string text1 = File.ReadAllText(path1,Encoding.UTF8);
         
         var contains=text.Contains("487777777");
         
          var contains_1=text1.Contains("487777777");
          if(contains && contains_1)
          {
          
           
            
          }
          
        File.Delete(path);
         File.Delete(path1);
        }
    }
}
