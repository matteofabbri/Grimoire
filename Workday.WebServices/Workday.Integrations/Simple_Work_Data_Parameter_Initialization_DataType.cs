using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Simple_Work_Data_Parameter_Initialization_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType simple_Work_Data_ReferenceField;

		private Parameter_Initialization_DataType parameter_Initialization_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Simple_Work_Data_Reference
		{
			get
			{
				return this.simple_Work_Data_ReferenceField;
			}
			set
			{
				this.simple_Work_Data_ReferenceField = value;
				this.RaisePropertyChanged("Simple_Work_Data_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Parameter_Initialization_DataType Parameter_Initialization_Data
		{
			get
			{
				return this.parameter_Initialization_DataField;
			}
			set
			{
				this.parameter_Initialization_DataField = value;
				this.RaisePropertyChanged("Parameter_Initialization_Data");
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
