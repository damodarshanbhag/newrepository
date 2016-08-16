/*
 * Created by Ranorex
 * User: Damodar Shanbhag
 * Date: 03-08-2016
 * Time: 09.56 AM
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

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace callflow_batch
{
    /// <summary>
    /// Description of editing_c.
    /// </summary>
    [TestModule("63524A17-324C-4F6F-9EF3-E47709909187", ModuleType.UserCode, 1)]
    public class editing_c : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public editing_c()
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
         text = text.Replace("522222333","487777777");
          File.WriteAllText(path, text,Encoding.UTF8);
        
        }
    }
}
