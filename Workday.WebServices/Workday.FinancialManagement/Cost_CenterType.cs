using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Cost_CenterType : INotifyPropertyChanged
	{
		private Cost_CenterObjectType cost_Center_ReferenceField;

		private Cost_Center_DataType cost_Center_DataField;

		private Simple_Cost_Center_DataType simple_Cost_Center_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Cost_CenterObjectType Cost_Center_Reference
		{
			get
			{
				return this.cost_Center_ReferenceField;
			}
			set
			{
				this.cost_Center_ReferenceField = value;
				this.RaisePropertyChanged("Cost_Center_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Cost_Center_DataType Cost_Center_Data
		{
			get
			{
				return this.cost_Center_DataField;
			}
			set
			{
				this.cost_Center_DataField = value;
				this.RaisePropertyChanged("Cost_Center_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Simple_Cost_Center_DataType Simple_Cost_Center_Data
		{
			get
			{
				return this.simple_Cost_Center_DataField;
			}
			set
			{
				this.simple_Cost_Center_DataField = value;
				this.RaisePropertyChanged("Simple_Cost_Center_Data");
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
