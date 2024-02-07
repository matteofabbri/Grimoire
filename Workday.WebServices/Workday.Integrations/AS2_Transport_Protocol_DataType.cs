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
	public class AS2_Transport_Protocol_DataType : INotifyPropertyChanged
	{
		private string aS2_EndpointField;

		private AS2_Settings_DataType aS2_Settings_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string AS2_Endpoint
		{
			get
			{
				return this.aS2_EndpointField;
			}
			set
			{
				this.aS2_EndpointField = value;
				this.RaisePropertyChanged("AS2_Endpoint");
			}
		}

		[XmlElement(Order = 1)]
		public AS2_Settings_DataType AS2_Settings_Data
		{
			get
			{
				return this.aS2_Settings_DataField;
			}
			set
			{
				this.aS2_Settings_DataField = value;
				this.RaisePropertyChanged("AS2_Settings_Data");
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
