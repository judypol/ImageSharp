﻿// <copyright file="IPackedBytes.cs" company="James Jackson-South">
// Copyright (c) James Jackson-South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

namespace ImageProcessorCore
{
    /// <summary>
    /// An interface that converts packed vector types to and from <see cref="byte[]"/> values, 
    /// allowing multiple encodings to be manipulated in a generic manner.
    /// </summary>
    /// <typeparam name="TPacked">The packed format. <example>uint, long, float.</example></typeparam>
    public interface IPackedBytes<TPacked>
        where TPacked : struct
    {
        /// <summary>
        /// Gets the packed representation from the gives bytes.
        /// </summary>
        /// <param name="r">The red component.</param>
        /// <param name="g">The green component.</param>
        /// <param name="b">The blue component.</param>
        /// <param name="a">The alpha component.</param>
        void PackFromBytes(byte r, byte g, byte b, byte a);

        /// <summary>
        /// Sets the packed representation into the gives bytes.
        /// </summary>
        /// <param name="bytes">The bytes to set the color in.</param>
        /// <param name="startIndex">The starting index of the <paramref name="bytes"/>.</param>
        /// <param name="componentOrder">The order of the components.</param>
        /// <returns>The <see cref="byte[]"/>.</returns>
        void ToBytes(byte[] bytes, int startIndex, ComponentOrder componentOrder);
    }
}