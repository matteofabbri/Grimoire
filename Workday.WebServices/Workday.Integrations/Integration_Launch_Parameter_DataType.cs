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
	public class Integration_Launch_Parameter_DataType : INotifyPropertyChanged
	{
		private Launch_ParameterObjectType launch_Parameter_ReferenceField;

		private Integration_Abstract_Value_DataType launch_Parameter_Value_DataField;

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
		public Integration_Abstract_Value_DataType Launch_Parameter_Value_Data
		{
			get
			{
				return this.launch_Parameter_Value_DataField;
			}
			set
			{
				this.launch_Parameter_Value_DataField = value;
				this.RaisePropertyChanged("Launch_Parameter_Value_Data");
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
