// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// A Job Release task to run on job completion on any compute node where
    /// the job has run.
    /// </summary>
    public partial class JobReleaseTask
    {
        /// <summary>
        /// Initializes a new instance of the JobReleaseTask class.
        /// </summary>
        public JobReleaseTask() { }

        /// <summary>
        /// Initializes a new instance of the JobReleaseTask class.
        /// </summary>
        /// <param name="commandLine">The command line of the Job Release
        /// task.</param>
        /// <param name="id">A string that uniquely identifies the Job Release
        /// task within the job.</param>
        /// <param name="resourceFiles">A list of files that the Batch service
        /// will download to the compute node before running the command
        /// line.</param>
        /// <param name="environmentSettings">A list of environment variable
        /// settings for the Job Release task.</param>
        /// <param name="maxWallClockTime">The maximum elapsed time that the
        /// Job Release task may run on a given compute node, measured from
        /// the time the task starts. If the task does not complete within
        /// the time limit, the Batch service terminates it. The default
        /// value is 15 minutes.</param>
        /// <param name="retentionTime">The minimum time to retain the working
        /// directory for the Job Release task on the compute node. After
        /// this time, the Batch service may delete the working directory and
        /// all its contents.</param>
        /// <param name="runElevated">Whether to run the Job Release task in
        /// elevated mode.</param>
        public JobReleaseTask(string commandLine, string id = default(string), System.Collections.Generic.IList<ResourceFile> resourceFiles = default(System.Collections.Generic.IList<ResourceFile>), System.Collections.Generic.IList<EnvironmentSetting> environmentSettings = default(System.Collections.Generic.IList<EnvironmentSetting>), System.TimeSpan? maxWallClockTime = default(System.TimeSpan?), System.TimeSpan? retentionTime = default(System.TimeSpan?), bool? runElevated = default(bool?))
        {
            Id = id;
            CommandLine = commandLine;
            ResourceFiles = resourceFiles;
            EnvironmentSettings = environmentSettings;
            MaxWallClockTime = maxWallClockTime;
            RetentionTime = retentionTime;
            RunElevated = runElevated;
        }

        /// <summary>
        /// Gets or sets a string that uniquely identifies the Job Release
        /// task within the job.
        /// </summary>
        /// <remarks>
        /// The id can contain any combination of alphanumeric characters
        /// including hyphens and underscores and cannot contain more than 64
        /// characters.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the command line of the Job Release task.
        /// </summary>
        /// <remarks>
        /// The command line does not run under a shell, and therefore cannot
        /// take advantage of shell features such as environment variable
        /// expansion. If you want to take advantage of such features, you
        /// should invoke the shell in the command line, for example using
        /// "cmd /c MyCommand" in Windows or "/bin/sh -c MyCommand" in Linux.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "commandLine")]
        public string CommandLine { get; set; }

        /// <summary>
        /// Gets or sets a list of files that the Batch service will download
        /// to the compute node before running the command line.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resourceFiles")]
        public System.Collections.Generic.IList<ResourceFile> ResourceFiles { get; set; }

        /// <summary>
        /// Gets or sets a list of environment variable settings for the Job
        /// Release task.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "environmentSettings")]
        public System.Collections.Generic.IList<EnvironmentSetting> EnvironmentSettings { get; set; }

        /// <summary>
        /// Gets or sets the maximum elapsed time that the Job Release task
        /// may run on a given compute node, measured from the time the task
        /// starts. If the task does not complete within the time limit, the
        /// Batch service terminates it. The default value is 15 minutes.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "maxWallClockTime")]
        public System.TimeSpan? MaxWallClockTime { get; set; }

        /// <summary>
        /// Gets or sets the minimum time to retain the working directory for
        /// the Job Release task on the compute node. After this time, the
        /// Batch service may delete the working directory and all its
        /// contents.
        /// </summary>
        /// <remarks>
        /// The default is infinite.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "retentionTime")]
        public System.TimeSpan? RetentionTime { get; set; }

        /// <summary>
        /// Gets or sets whether to run the Job Release task in elevated mode.
        /// </summary>
        /// <remarks>
        /// The default value is false.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "runElevated")]
        public bool? RunElevated { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CommandLine == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "CommandLine");
            }
            if (this.ResourceFiles != null)
            {
                foreach (var element in this.ResourceFiles)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.EnvironmentSettings != null)
            {
                foreach (var element1 in this.EnvironmentSettings)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}