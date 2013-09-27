﻿// OsmSharp - OpenStreetMap (OSM) SDK
// Copyright (C) 2013 Abelshausen Ben
// 
// This file is part of OsmSharp.
// 
// OsmSharp is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
// 
// OsmSharp is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with OsmSharp. If not, see <http://www.gnu.org/licenses/>.

using OsmSharp.Math.Geo;
using OsmSharp.Units.Angle;

namespace OsmSharp.UI
{
    /// <summary>
    /// Abstracts an implementation of a MapView with a MapCenter, MapTilt and MapZoom.
    /// </summary>
    public interface IMapView
    {
        /// <summary>
        /// Gets or sets the MapCenter;
        /// </summary>
        GeoCoordinate MapCenter { get; set; }

        /// <summary>
        /// Gets or sets the MapTilt.
        /// </summary>
        Degree MapTilt { get; set; }

        /// <summary>
        /// Gets or sets the MapZoom.
        /// </summary>
        float MapZoom { get; set; }
    }
}