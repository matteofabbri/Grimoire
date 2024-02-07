using System;
using System.Linq;
using System.Collections.Generic;

using numl.Data;

namespace numl.AI
{
    /// <summary>
    /// Interface ISuccessor
    /// </summary>
    public interface ISuccessor
    {
        /// <summary>
        /// Gets the cost.
        /// </summary>
        /// <value>The cost.</value>
        double Cost { get; }

        /// <summary>
        /// Gets the action.
        /// </summary>
        /// <value>The action.</value>
        IAction Action { get; }

        /// <summary>
        /// Gets the state.
        /// </summary>
        /// <value>The state.</value>
        IState State { get; }
    }
}
