﻿namespace SwedbankPay.Sdk.JsonSerialization
{
    using System;
    using System.Linq;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CustomLanguageConverter : JsonConverter

    {
        private readonly Type[] types;

        public CustomLanguageConverter(params Type[] types)
        {
            this.types = types;
        }

        public CustomLanguageConverter()
        {

        }

        public override void WriteJson(JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
        {
            var t = JToken.FromObject(value);

            if (t.Type != JTokenType.Object)
            {
                t.WriteTo(writer);
            }
            else
            {
                writer.WriteValue(value.ToString());
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.StartObject)
            {
                var jo = JObject.Load(reader);
                var languageCode = jo.Values().FirstOrDefault()?.ToString();
                return new Language(languageCode);
            }

            return new Language(reader.Value.ToString());
        }

        public override bool CanRead => true;

        public override bool CanConvert(Type objectType)
        {
            return this.types.Any(t => t == objectType);
        }
    }
}