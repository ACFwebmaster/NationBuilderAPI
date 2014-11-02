﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace NationBuilderAPI.V1.Webhooks.V4.AutoSerializable
{
    [DataContract]
    [KnownType(typeof(PersonWebhookContent))]
    public class PersonWebhookContent
    {
        [DataMember]
        public string nation_slug;

        [DataMember]
        public PersonWebhookPayload payload;

        /// <summary>
        /// The webhook secret token that can be used to verify the authenticity of the submitted webhook data.
        /// </summary>
        [DataMember]
        public string token;

        /// <summary>
        /// The webhook structure version.  If the meaning of submitted webhook fields changes, this version will increase.
        /// </summary>
        [DataMember]
        public int version;
    }
}