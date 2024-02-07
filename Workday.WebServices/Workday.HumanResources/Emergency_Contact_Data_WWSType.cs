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
	public class Emergency_Contact_Data_WWSType : INotifyPropertyChanged
	{
		private IDType[] integration_ID_DataField;

		private Language_ReferenceType[] language_ReferenceField;

		private Emergency_Contact_Priority_ReferenceType[] emergency_Contact_Priority_ReferenceField;

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

		[XmlElement("Language_Reference", Order = 1)]
		public Language_ReferenceType[] Language_Reference
		{
			get
			{
				return this.language_ReferenceField;
			}
			set
			{
				this.language_ReferenceField = value;
				this.RaisePropertyChanged("Language_Reference");
			}
		}

		[XmlElement("Emergency_Contact_Priority_Reference", Order = 2)]
		public Emergency_Contact_Priority_ReferenceType[] Emergency_Contact_Priority_Reference
		{
			get
			{
				return this.emergency_Contact_Priority_ReferenceField;
			}
			set
			{
				this.emergency_Contact_Priority_ReferenceField = value;
				this.RaisePropertyChanged("Emergency_Contact_Priority_Reference");
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
