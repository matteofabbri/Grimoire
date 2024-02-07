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
	public class Integration_Field_Override_Parameter_Initialization_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType external_Parameter_ReferenceField;

		private Parameter_Initialization_WWS_DataType parameter_Initialization_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType External_Parameter_Reference
		{
			get
			{
				return this.external_Parameter_ReferenceField;
			}
			set
			{
				this.external_Parameter_ReferenceField = value;
				this.RaisePropertyChanged("External_Parameter_Reference");
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
