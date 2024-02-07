using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Service_Center_Representative_DataType : INotifyPropertyChanged
	{
		private Service_CenterObjectType[] service_Center_ReferenceField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private Legal_Name_DataType name_DataField;

		private Contact_Information_DataType contact_Information_DataField;

		private string idField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Service_Center_Reference", Order = 0)]
		public Service_CenterObjectType[] Service_Center_Reference
		{
			get
			{
				return this.service_Center_ReferenceField;
			}
			set
			{
				this.service_Center_ReferenceField = value;
				this.RaisePropertyChanged("Service_Center_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Legal_Name_DataType Name_Data
		{
			get
			{
				return this.name_DataField;
			}
			set
			{
				this.name_DataField = value;
				this.RaisePropertyChanged("Name_Data");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
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
