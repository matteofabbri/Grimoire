using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Customer_Business_Entity_WWS_DataType : INotifyPropertyChanged
	{
		private string business_Entity_NameField;

		private string external_Entity_IDField;

		private Contact_Information_DataType contact_DataField;

		private Business_Entity_Logo_Image_DataType business_Entity_Logo_Image_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Business_Entity_Name
		{
			get
			{
				return this.business_Entity_NameField;
			}
			set
			{
				this.business_Entity_NameField = value;
				this.RaisePropertyChanged("Business_Entity_Name");
			}
		}

		[XmlElement(Order = 1)]
		public string External_Entity_ID
		{
			get
			{
				return this.external_Entity_IDField;
			}
			set
			{
				this.external_Entity_IDField = value;
				this.RaisePropertyChanged("External_Entity_ID");
			}
		}

		[XmlElement(Order = 2)]
		public Contact_Information_DataType Contact_Data
		{
			get
			{
				return this.contact_DataField;
			}
			set
			{
				this.contact_DataField = value;
				this.RaisePropertyChanged("Contact_Data");
			}
		}

		[XmlElement(Order = 3)]
		public Business_Entity_Logo_Image_DataType Business_Entity_Logo_Image_Data
		{
			get
			{
				return this.business_Entity_Logo_Image_DataField;
			}
			set
			{
				this.business_Entity_Logo_Image_DataField = value;
				this.RaisePropertyChanged("Business_Entity_Logo_Image_Data");
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
