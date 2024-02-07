using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Emergency_Contact_Personal_Information_DataType : INotifyPropertyChanged
	{
		private Person_Name_DataType[] person_Name_DataField;

		private Contact_Information_DataType[] contact_Information_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Person_Name_Data", Order = 0)]
		public Person_Name_DataType[] Person_Name_Data
		{
			get
			{
				return this.person_Name_DataField;
			}
			set
			{
				this.person_Name_DataField = value;
				this.RaisePropertyChanged("Person_Name_Data");
			}
		}

		[XmlElement("Contact_Information_Data", Order = 1)]
		public Contact_Information_DataType[] Contact_Information_Data
		{
			get
			{
				return this.contact_Information_DataField;
			}
			set
			{
				this.contact_Information_DataField = value;
				this.RaisePropertyChanged("Contact_Information_Data");
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
