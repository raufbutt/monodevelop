// 
// ReferenceNodeBuilder.cs
//  
// Author:
//       Lluis Sanchez Gual <lluis@novell.com>
// 
// Copyright (c) 2009 Novell, Inc (http://www.novell.com)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using MonoDevelop.Projects;
using MonoDevelop.Ide.Gui.Components;
using MonoDevelop.Ide.Gui.Pads.ProjectPad;

namespace MonoDevelop.AddinAuthoring.NodeBuilders
{
	public class ReferenceNodeBuilder: NodeBuilderExtension
	{
		public override bool CanBuildNode (System.Type dataType)
		{
			return typeof(ProjectReference).IsAssignableFrom (dataType);
		}
		
		public override void GetNodeAttributes (ITreeNavigator parentNode, object dataObject, ref NodeAttributes attributes)
		{
			if (dataObject is AddinProjectReference) {
				attributes |= NodeAttributes.Hidden;
				return;
			}
			ProjectReference pr = (ProjectReference) dataObject;
			DotNetProject parent = pr.OwnerProject as DotNetProject;
			if (AddinAuthoringService.IsProjectIncludedByAddin (parent, pr)) {
				attributes |= NodeAttributes.Hidden;
			}
			else if (parent.GetAddinData () != null && pr.ReferenceType == ReferenceType.Project) {
				DotNetProject tp = parent.ParentSolution.FindProjectByName (pr.Reference) as DotNetProject;
				if (tp != null && tp.GetAddinData () != null)
					attributes |= NodeAttributes.Hidden;
			}
		}
	}
}
