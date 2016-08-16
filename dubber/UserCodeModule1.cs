/*
 * Created by Ranorex
 * User: Damodar Shanbhag
 * Date: 25-07-2016
 * Time: 12:26
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

namespace dubber
{
    /// <summary>
    /// Description of UserCodeModule1.
    /// </summary>
    [TestModule("2FEA3686-3B43-42A8-8C5D-A4BE34373F58", ModuleType.UserCode, 1)]
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
            var repo = dubberrepo.Instance;
            var dubber = repo.Dubber;
               Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://tigers.dubber.net/login' with browser 'chrome' in normal mode.");
            Host.Local.OpenBrowser("https://tigers.dubber.net/login", "chrome", "", false, false, false, false, false);
            //login details
            var userEmail = repo.Dubber.UserEmail;
            userEmail.Value="qa+4@dubber.net";
            var userPassword = repo.Dubber.UserPassword;
            userPassword.Value="P@ssword1";
            var submitButton = repo.Dubber.SubmitButton;
            submitButton.Click();
           // var repo = dubberRepository.Instance;
           //click on dap button
            var manageDapsButton = repo.Dubber.ManageDapsButton;
            manageDapsButton.Click();
            //adding dap
            var newDap = repo.Dubber.NewDap;
            newDap.Click();
       
            var dapAreaId = repo.Dubber.DapAreaId;
            dapAreaId.Click();
            //var repo1 = dubberRepository.Instance;
            var dropdown = repo.Dropdown;

           //click on drop down button
           
            
             var areaDescription = repo.Dubber.AreaDescription;
             areaDescription.Click();
           areaDescription.Value="jhvcasigc";
      
           var areaState = repo.Dubber.AreaState;
       areaState.Click();
       areaState.Value="denmark";
       
       var areaCountry = repo.Dubber.AreaCountry;
       
    Report.Log(ReportLevel.Info, "Set Value", "Setting attribute TagValue to 'Albania' on item 'Dubber.AreaCountry'.", repo.Dubber.AreaCountryInfo);
            repo.Dubber.AreaCountry.Element.SetAttributeValue("TagValue", "Albania");
     
     
     var newAreaOkButton = repo.Dubber.NewAreaOkButton;
     newAreaOkButton.Click();
    

            var profileDdt = repo.Dubber.ProfileDdt;
            profileDdt.Click();
            var dropDownLogout = repo.Dubber.DropDownLogout;
            dropDownLogout.Click();


        }
        
    }
}
