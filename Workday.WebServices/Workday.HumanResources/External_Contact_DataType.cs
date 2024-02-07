using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class External_Contact_DataType : INotifyPropertyChanged
	{
		private IDType[] integration_ID_DataField;

		private string external_Contact_TypeField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlArray(Order = 0), XmlArrayItem("ID", IsNullable = false)]
		public IDType[] Integration_ID_Data
		{
			get
			{
				return this.integration_ID_DataField;
			}
			set
			{
				this.integration_ID_DataField = value;
				this.RaisePropertyChanged("Integration_ID_Data");
			}
		}

		[XmlElement(Order = 1)]
		public string External_Contact_Type
		{
			get
			{
				return this.external_Contact_TypeField;
			}
			set
			{
				this.external_Contact_TypeField = value;
				this.RaisePropertyChanged("External_Contact_Type");
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
