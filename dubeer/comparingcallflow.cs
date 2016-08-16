/*
 * Created by Ranorex
 * User: Damodar Shanbhag
 * Date: 27-07-2016
 * Time: 12.50 PM
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

namespace dubeer
{
    /// <summary>
    /// Description of comparingcallflow.
    /// </summary>
    [TestModule("4D988D98-83A8-4A4C-899A-F1577A9F4293", ModuleType.UserCode, 1)]
    public class comparingcallflow : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
          public static dubeerRepository repo = dubeerRepository.Instance;
        public comparingcallflow()
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
         
       string path1 = @"C:\Users\Damodar Shanbhag\Downloads\inb-Callflow (1).xml";
         string text1 = File.ReadAllText(path1,Encoding.UTF8);
         
         var contains=text.Contains("487776660");
         
          var contains_1=text1.Contains("487776660");
          if(contains==contains_1)
          {

          	var profileDdt = repo.Dubber.ProfileDdt;
          	profileDdt.Click();
          	
          	var dropDownLogout = repo.Dubber.DropDownLogout;
          	dropDownLogout.Click();
  
          }
          File.Delete(path);
         File.Delete(path1);
        }
    }
}
