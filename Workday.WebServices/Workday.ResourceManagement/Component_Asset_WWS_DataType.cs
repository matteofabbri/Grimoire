using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Component_Asset_WWS_DataType : INotifyPropertyChanged
	{
		private string component_Asset_IDField;

		private decimal quantity_SelectedField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Component_Asset_ID
		{
			get
			{
				return this.component_Asset_IDField;
			}
			set
			{
				this.component_Asset_IDField = value;
				this.RaisePropertyChanged("Component_Asset_ID");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Quantity_Selected
		{
			get
			{
				return this.quantity_SelectedField;
			}
			set
			{
				this.quantity_SelectedField = value;
				this.RaisePropertyChanged("Quantity_Selected");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
