/*
 * Created by Ranorex
 * User: Damodar Shanbhag
 * Date: 26-07-2016
 * Time: 11.08 AM
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

namespace dubeer
{
    /// <summary>
    /// Description of UserCodeModule1.
    /// </summary>
    [TestModule("42845C2D-A81C-47EC-8CD5-64774A195740", ModuleType.UserCode, 1)]
    public class UserCodeModule1 : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UserCodeModule1()
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
            
            //var repo = dubeerRepository.Instance;
         //   var state = repo.DubberMozillaFirefox.State;
          
            
             Host.Local.OpenBrowser("https://tigers.dubber.net/login", "Chrome", "", false, false, false, false, false);
           // Delay.Milliseconds(0);
        }
    }
}
