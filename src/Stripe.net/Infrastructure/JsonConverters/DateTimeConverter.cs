namespace Stripe.Infrastructure
{
    using System;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class DateTimeConverter : DateTimeConverterBase
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (writer == null)
            {
                throw new ArgumentNullException(nameof(writer));
            }

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                var unixTime = ((DateTime)value).ConvertDateTimeToEpoch();
                writer.WriteRawValue(unixTime.ToString(CultureInfo.InvariantCulture));
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader == null)
            {
                throw new ArgumentNullException(nameof(reader));
            }

            if (reader.Value == null)
            {
                return null;
            }

            if (reader.TokenType == JsonToken.Integer)
            {
                return EpochTime.ConvertEpochToDateTime((long)reader.Value);
            }

            return DateTime.Parse(reader.Value.ToString(), CultureInfo.InvariantCulture);
        }
    }
}
