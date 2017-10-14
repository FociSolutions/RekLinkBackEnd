using Geocoding;
using Geocoding.Google;
using System;

namespace IO.Swagger.Services
{
    public class MapPointService
    {
        IGeocoder geoCoder;

        public IGeocoder CreateAsyncGeocoder()
        {
            string apiKey = string.Empty; // settings.GoogleApiKey;

            if (String.IsNullOrEmpty(apiKey))
            {
                geoCoder = new GoogleGeocoder();
            }
            else
            {
                geoCoder = new GoogleGeocoder(apiKey);
            }

            return geoCoder;
        }

    }
}
