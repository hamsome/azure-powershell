// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using Microsoft.Azure;
using Microsoft.WindowsAzure.Commands.Compute.Automation.Models;
using Microsoft.WindowsAzure.Management.Compute;
using Microsoft.WindowsAzure.Management.Compute.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.WindowsAzure.Commands.Compute.Automation
{
    public partial class InvokeAzureComputeMethodCmdlet : ComputeAutomationBaseCmdlet
    {
        protected object CreateVirtualMachineVMImageUpdateDynamicParameters()
        {
            dynamicParameters = new RuntimeDefinedParameterDictionary();
            var pImageName = new RuntimeDefinedParameter();
            pImageName.Name = "ImageName";
            pImageName.ParameterType = typeof(System.String);
            pImageName.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 1,
                Mandatory = true
            });
            pImageName.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("ImageName", pImageName);

            var pParameters = new RuntimeDefinedParameter();
            pParameters.Name = "VirtualMachineVMImageUpdateParameters";
            pParameters.ParameterType = typeof(Microsoft.WindowsAzure.Management.Compute.Models.VirtualMachineVMImageUpdateParameters);
            pParameters.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 2,
                Mandatory = true
            });
            pParameters.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("VirtualMachineVMImageUpdateParameters", pParameters);

            var pArgumentList = new RuntimeDefinedParameter();
            pArgumentList.Name = "ArgumentList";
            pArgumentList.ParameterType = typeof(object[]);
            pArgumentList.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByStaticParameters",
                Position = 3,
                Mandatory = true
            });
            pArgumentList.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("ArgumentList", pArgumentList);

            return dynamicParameters;
        }

        protected void ExecuteVirtualMachineVMImageUpdateMethod(object[] invokeMethodInputParameters)
        {
            string imageName = (string)ParseParameter(invokeMethodInputParameters[0]);
            VirtualMachineVMImageUpdateParameters parameters = (VirtualMachineVMImageUpdateParameters)ParseParameter(invokeMethodInputParameters[1]);

            var result = VirtualMachineVMImageClient.Update(imageName, parameters);
            WriteObject(result);
        }
    }

    public partial class NewAzureComputeArgumentListCmdlet : ComputeAutomationBaseCmdlet
    {
        protected PSArgument[] CreateVirtualMachineVMImageUpdateParameters()
        {
            string imageName = string.Empty;
            VirtualMachineVMImageUpdateParameters parameters = new VirtualMachineVMImageUpdateParameters();

            return ConvertFromObjectsToArguments(new string[] { "ImageName", "Parameters" }, new object[] { imageName, parameters });
        }
    }
}