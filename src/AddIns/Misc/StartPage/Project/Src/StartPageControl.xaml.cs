﻿// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Daniel Grunwald"/>
//     <version>$Revision$</version>
// </file>

using System;
using System.Collections.Generic;
using System.Windows.Controls;

using ICSharpCode.Core;

namespace ICSharpCode.StartPage
{
	/// <summary>
	/// Interaction logic for StartPageControl.xaml
	/// </summary>
	public partial class StartPageControl : UserControl
	{
		public StartPageControl()
		{
			InitializeComponent();
			List<object> items = AddInTree.BuildItems<object>("/SharpDevelop/ViewContent/StartPage/Items", this, false);
			// WPF does not use DataTemplates if the item already is a UIElement; so we 'box' it.
			List<BoxEntry> entries = items.ConvertAll(control => new BoxEntry { Control = control } );
			startPageItems.ItemsSource = entries;
		}
		
		sealed class BoxEntry
		{
			public object Control { get; set; }
		}
	}
}