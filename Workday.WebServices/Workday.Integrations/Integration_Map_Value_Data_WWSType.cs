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
	public class Integration_Map_Value_Data_WWSType : INotifyPropertyChanged
	{
		private Integration_Abstract_Value_DataType internal_Value_DataField;

		private Copy_of_Integration_Abstract_Value_DataType external_Value_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Integration_Abstract_Value_DataType Internal_Value_Data
		{
			get
			{
				return this.internal_Value_DataField;
			}
			set
			{
				this.internal_Value_DataField = value;
				this.RaisePropertyChanged("Internal_Value_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Copy_of_Integration_Abstract_Value_DataType External_Value_Data
		{
			get
			{
				return this.external_Value_DataField;
			}
			set
			{
				this.external_Value_DataField = value;
				this.RaisePropertyChanged("External_Value_Data");
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
