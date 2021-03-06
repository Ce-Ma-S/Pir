﻿using System;

namespace Common.Events
{
    /// <summary>
    /// Changeable object.
    /// </summary>
    public interface IChangeable
    {
        /// <summary>
        /// Fired when this object is changed.
        /// </summary>
        event EventHandler Changed;
    }
}
