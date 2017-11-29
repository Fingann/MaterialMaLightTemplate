using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingannTemplate.Services.Navigation.Interfaces
{
    /// <summary>
    /// The Displayable interface.
    /// </summary>
    public interface IDisplayable
    {
        
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        string DisplayTitle { get; set; }

        /// <summary>
        /// Gets or sets the parameter used for communication between DisplayableViews.
        /// </summary>
        object Parameter { get; set; }

    }
}
