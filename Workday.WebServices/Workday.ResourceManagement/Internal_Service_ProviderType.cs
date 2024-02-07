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
	public class Internal_Service_ProviderType : INotifyPropertyChanged
	{
		private Internal_Service_ProviderObjectType internal_Service_Provider_ReferenceField;

		private Internal_Service_Provider_DataType[] internal_Service_Provider_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Internal_Service_ProviderObjectType Internal_Service_Provider_Reference
		{
			get
			{
				return this.internal_Service_Provider_ReferenceField;
			}
			set
			{
				this.internal_Service_Provider_ReferenceField = value;
				this.RaisePropertyChanged("Internal_Service_Provider_Reference");
			}
		}

		[XmlElement("Internal_Service_Provider_Data", Order = 1)]
		public Internal_Service_Provider_DataType[] Internal_Service_Provider_Data
		{
			get
			{
				return this.internal_Service_Provider_DataField;
			}
			set
			{
				this.internal_Service_Provider_DataField = value;
				this.RaisePropertyChanged("Internal_Service_Provider_Data");
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
