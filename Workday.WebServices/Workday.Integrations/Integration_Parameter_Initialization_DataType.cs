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
	public class Integration_Parameter_Initialization_DataType : INotifyPropertyChanged
	{
		private Launch_ParameterObjectType launch_Parameter_ReferenceField;

		private Parameter_Initialization_WWS_DataType parameter_Initialization_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Launch_ParameterObjectType Launch_Parameter_Reference
		{
			get
			{
				return this.launch_Parameter_ReferenceField;
			}
			set
			{
				this.launch_Parameter_ReferenceField = value;
				this.RaisePropertyChanged("Launch_Parameter_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Parameter_Initialization_WWS_DataType Parameter_Initialization_Data
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
