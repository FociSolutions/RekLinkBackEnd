/*
 * Mapping API
 *
 * RekLink Mapping API
 *
 * OpenAPI spec version: 1.0.0
 * Contact: dan.mccrady@focisolutions.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.SwaggerGen.Annotations;
using IO.Swagger.Models;
using Geocoding;
using IO.Swagger.Services;
using IO.Swagger.Services.Interfaces;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class OpenApiController : Controller
    {
        private IMapPointService mapPointService;

        public OpenApiController(IMapPointService mapPointService)
        {
            this.mapPointService = mapPointService;
        }

        /// <summary>
        /// adds a mapping point
        /// </summary>
        /// <remarks>Adds a mapping point data</remarks>
        /// <param name="mapPoint">Mapping Data to add</param>
        /// <response code="201">Mapping point added</response>
        /// <response code="400">invalid input, object invalid</response>
        /// <response code="409">an existing item already exists</response>
        [HttpPost]
        [Route("/RecLink/RecLInkMapping/1.0.0/MappingPoint")]
        [SwaggerOperation("AddMappingPoint")]
        public virtual IActionResult AddMappingPoint([FromBody]MapPointDTO mapPoint)
        {

            return new ObjectResult((mapPointService.AddMapdData(mapPoint)));
        }

    /// <summary>
        /// Gets all mapping points
        /// </summary>
        /// <remarks>By passing in the appropriate options, you can search for available mapping points in the system </remarks>
        /// <response code="200">search results matching criteria</response>
        /// <response code="400">bad input parameter</response>
        [HttpGet]
        [Route("/RecLink/RecLInkMapping/1.0.0/MappingPoint")]
        [SwaggerOperation("SearchInventory")]
        [SwaggerResponse(200, type: typeof(List<MapPointDTO>))]
        public virtual IActionResult SearchInventory([FromQuery]double neLat, [FromQuery]double neLong, [FromQuery]double swLat, [FromQuery]double swLong)
        {
            var example = this.mapPointService.GetFencedData(neLat, neLong, swLat, swLong);

            return new ObjectResult(example);
        }
    }
}
