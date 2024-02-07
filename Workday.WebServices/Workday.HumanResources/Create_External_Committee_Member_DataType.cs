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
	public class Create_External_Committee_Member_DataType : INotifyPropertyChanged
	{
		private Person_Name_DataType person_Name_DataField;

		private Contact_Information_DataType contact_Information_DataField;

		private Custom_IDType[] custom_IDField;

		private Person_Photo_DataType person_Photo_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Person_Name_DataType Person_Name_Data
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

		[XmlElement(Order = 1)]
		public Contact_Information_DataType Contact_Information_Data
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

		[XmlElement("Custom_ID", Order = 2)]
		public Custom_IDType[] Custom_ID
		{
			get
			{
				return this.custom_IDField;
			}
			set
			{
				this.custom_IDField = value;
				this.RaisePropertyChanged("Custom_ID");
			}
		}

		[XmlElement(Order = 3)]
		public Person_Photo_DataType Person_Photo_Data
		{
			get
			{
				return this.person_Photo_DataField;
			}
			set
			{
				this.person_Photo_DataField = value;
				this.RaisePropertyChanged("Person_Photo_Data");
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
