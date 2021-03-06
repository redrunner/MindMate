﻿/* Author: Syed Umar Anis (mail@umaranis.com)                    
 * Copyright (c) 2014 Syed Umar Anis                             
 * This software is licensed under MIT (see LICENSE.txt)    
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MindMate.Model
{
    public enum NodeRichContentType { NONE, NODE, NOTE }

    public enum NodeShape { None, Fork, Bubble, Box, Bullet }

    public enum NodePosition : int { Root = 0, Left = 1, Right = 2, Undefined = -1 };

    public enum NodeProperties
    {
        Text,
        Folded,
        Bold,
        Italic,
        FontName,
        FontSize,
        Link,
        BackColor,
        Color,
        Shape,
        LineWidth,
        LinePattern,
        LineColor,
        RichContentType,
        RichContentText
    }

    public enum IconChange
    {
        Added,
        Removed
    }

    public enum AttributeChange
    {
        Added,
        Removed,
        ValueUpdated
    }

    public enum TreeStructureChange
    {
        /// <summary>
        /// Not invoked if existing node is attached. 
        /// </summary>
        New,       
        /// <summary>
        /// Applicable only to childs of root node
        /// </summary>
        MovedLeft,  
        /// <summary>
        /// Applicable only to childs of root node
        /// </summary>
        MovedRight, 
        /// <summary>
        /// Invoked after existing node is attached
        /// </summary>
        Attached,
        /// <summary>
        /// Before a node is detached
        /// </summary>
        Detaching,
        /// <summary>
        /// Before a node is deleted
        /// </summary>
        Deleting,
        MovedUp,
        MovedDown
    }


    public enum NodeLinkType
    {
        File,
        ImageFile,
        VideoFile, //audio included in this
        Folder,
        MindMapNode,
        Executable,
        InternetLink,
        EmailLink,
        Empty
    }       
    
}
