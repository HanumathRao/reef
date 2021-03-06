﻿// Licensed to the Apache Software Foundation (ASF) under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  The ASF licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.

using System.Runtime.Serialization;
using Org.Apache.REEF.Utilities.Attributes;

namespace Org.Apache.REEF.Common.Avro
{
    /// <summary>
    /// Used to serialize and deserialize Avro record org.apache.reef.javabridge.avro.AvroFailedTask.
    /// This is a (mostly) auto-generated class. For instructions on how to regenerate, please view the README.md in the same folder.
    /// </summary>
    [Private]
    [DataContract(Namespace = "org.apache.reef.javabridge.avro")]
    public sealed class AvroFailedTask
    {
        private const string JsonSchema = @"{""type"":""record"",""name"":""org.apache.reef.javabridge.avro.AvroFailedTask"",""doc"":""Defines the schema for the failed task."",""fields"":[{""name"":""identifier"",""type"":""string""},{""name"":""data"",""type"":""bytes""},{""name"":""cause"",""type"":""bytes""},{""name"":""message"",""type"":""string""}]}";

        /// <summary>
        /// Gets the schema.
        /// </summary>
        public static string Schema
        {
            get
            {
                return JsonSchema;
            }
        }

        /// <summary>
        /// Gets or sets the identifier field.
        /// </summary>
        [DataMember]
        public string identifier { get; set; }

        /// <summary>
        /// Gets or sets the data field.
        /// </summary>
        [DataMember]
        public byte[] data { get; set; }

        /// <summary>
        /// Gets or sets the cause field.
        /// </summary>
        [DataMember]
        public byte[] cause { get; set; }

        /// <summary>
        /// Gets or sets the message field.
        /// </summary>
        [DataMember]
        public string message { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AvroFailedTask"/> class.
        /// </summary>
        public AvroFailedTask()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AvroFailedTask"/> class.
        /// </summary>
        /// <param name="identifier">The identifier.</param>
        /// <param name="data">The data.</param>
        /// <param name="cause">The cause.</param>
        /// <param name="message">The message.</param>
        public AvroFailedTask(string identifier, byte[] data, byte[] cause, string message)
        {
            this.identifier = identifier;
            this.data = data;
            this.cause = cause;
            this.message = message;
        }
    }
}
