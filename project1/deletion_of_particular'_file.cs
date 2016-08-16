/*
 * Created by Ranorex
 * User: Damodar Shanbhag
 * Date: 27-07-2016
 * Time: 11.03 AM
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
    /// Description of deletion_of_particular__file.
    /// </summary>
    [TestModule("A20DF633-2065-4567-BEA2-F7267DBD9721", ModuleType.UserCode, 1)]
    public class deletion_of_particular__file : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public deletion_of_particular__file()
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
            
            string Path=@"C:\Users\Damodar Shanbhag\Downloads\inb-Callflow.xml";
            string Path1=@"C:\Users\Damodar Shanbhag\Downloads\inb-Callflow(1).xml";
            System.IO.File.Delete(Path1);
            System.IO.File.Delete(Path);
            	
        }
    }
}
