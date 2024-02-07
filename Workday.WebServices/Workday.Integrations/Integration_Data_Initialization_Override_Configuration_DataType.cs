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
	public class Integration_Data_Initialization_Override_Configuration_DataType : INotifyPropertyChanged
	{
		private Overridden_Integration_Document_Field_DataType[] integration_Document_Field_for_Field_Override_DataField;

		private Extended_Integration_Document_Field_DataType[] integration_Document_Field_for_Document_Extension_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Integration_Document_Field_for_Field_Override_Data", Order = 0)]
		public Overridden_Integration_Document_Field_DataType[] Integration_Document_Field_for_Field_Override_Data
		{
			get
			{
				return this.integration_Document_Field_for_Field_Override_DataField;
			}
			set
			{
				this.integration_Document_Field_for_Field_Override_DataField = value;
				this.RaisePropertyChanged("Integration_Document_Field_for_Field_Override_Data");
			}
		}

		[XmlElement("Integration_Document_Field_for_Document_Extension_Data", Order = 1)]
		public Extended_Integration_Document_Field_DataType[] Integration_Document_Field_for_Document_Extension_Data
		{
			get
			{
				return this.integration_Document_Field_for_Document_Extension_DataField;
			}
			set
			{
				this.integration_Document_Field_for_Document_Extension_DataField = value;
				this.RaisePropertyChanged("Integration_Document_Field_for_Document_Extension_Data");
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
